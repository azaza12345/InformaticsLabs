using System;

namespace Diophantine
{
    class Program
    {
        static int percentageOfMembers = 10;
        static int d;
        static int membersGenerated = 0;
        static int[] arrayOfa;
        static int[] arrayOfx;
        static int bruteForceIterations;
        static double sum;
        static Member[] members;
        static DateTime startTime;
        static TimeSpan endTime;

        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа решает линейные диофантовы уравнения вида:\nA0*X0+A1*X1+A2*X2+...+Ak*Xk=d (При k>1)");
            userDialog();
            if (userDialogType())   //Расчет методом генетического алгоритма
            {
                computeIterations();
                Console.Write("Всего итераций: ");
                writeWithColor(members.Length + "\nБудет сгенерировано 10% от данного числа.\n", ConsoleColor.Green, false);
                writeWithColor("Начало. Генерация особей.", ConsoleColor.Green);
                startTime = DateTime.Now;
                firstGeneration();
                updateSuitables();
                //Console.WriteLine("Для продолжения нажмите любую клавишу...");
                //Console.ReadKey();
                for (int i = membersGenerated; i < members.Length; i++)
                {
                    writeWithColor("Итерация №" + (i), ConsoleColor.Green);
                    members[i] = newMember();
                    updateSuitables();
                    //Console.WriteLine("Для продолжения нажмите любую клавишу...");
                    //Console.ReadKey();
                }
            }
            else
            {
                arrayOfx = new int[arrayOfa.Length];
                bruteForceIterations = 0;
                bruteForce();
                Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                Console.ReadKey();
            }
        }

        static void bruteForce(int i = 0, int sumOfx = 0)   //Метод грубой силы
        {
            bruteForceIterations++;
            if (i == arrayOfx.Length)
            {
                if (sumOfx == d)
                {
                    writeWithColor("Решение найдено за " + bruteForceIterations + " итераций");
                    foreach (int mem in arrayOfx)
                    {
                        Console.Write(mem + " ");
                    }
                    endTime = DateTime.Now - startTime;
                    Console.WriteLine("Решение найдено за:" + endTime);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                return;
            }
            else
                for (int k = 1; k < ((d - arrayOfx.Length) / arrayOfa[i]) + 1; k++)
                {
                    arrayOfx[i] = k;
                    bruteForce(i + 1, sumOfx + k * arrayOfa[i]);
                }
        }

        static void updateSuitables()   //Обновляем проценты и области вхождения
        {
            for (int i = 0; i < membersGenerated; i++)
            {
                if (i == 0) members[i].updateSuitable(sum, 0);
                else members[i].updateSuitable(sum, members[i - 1].end);
                writeMember(i);
                if (members[i].survivality == 0) foundSolution(i);  //Проверка на верное решение
            }
        }

        static void computeIterations() //Расчет числа возможных комбинаций
        {
            int iterations = 1;
            for (int i = 0; i < arrayOfa.Length; i++)
            {
                iterations *= (((d - arrayOfa.Length) / arrayOfa[i]) + 1);
            }
            userDialogIterations(ref iterations);
            members = new Member[iterations];
        }

        static bool userDialogType()
        {
            writeWithColor("Выберите метод решения:\n1 - Генетический алгоритм;\n2 - Метод перебора.", ConsoleColor.Green);
            string key = Console.ReadLine();
            if (key[0] == '1') return true;
            else if (key[0] == '2') return false;
            else
            {
                error("Введен неверный символ");
                return userDialogType();
            }
        }

        static void userDialogIterations(ref int iterations)
        {
            writeWithColor("Чтобы изменить максимальное число итераций введите положительное число <=" + iterations, ConsoleColor.Green);
            try
            {
                int k = Int32.Parse(Console.ReadLine());
                if (k <= 1)
                {
                    error("Введите положительное число");
                    userDialogIterations(ref iterations);
                    return;
                }
                if (k > iterations)
                {
                    error("Введите число итераций меньшее чем " + iterations);
                    userDialogIterations(ref iterations);
                    return;
                }
                iterations = k;
            }
            catch
            {
                error("Введите корректное число");
                userDialogIterations(ref iterations);
                return;
            }
        }

        static void userDialog()    //Диалог с пользователем
        {
            Console.Write("k=");
            try
            {
                int k = Int32.Parse(Console.ReadLine());
                if (k <= 1)
                {
                    error("Введите k>1");
                    userDialog();
                    return;
                }
                arrayOfa = new int[k];
            }
            catch
            {
                error("Введите корректное число");
                userDialog();
                return;
            }
            Console.Write("d=");
            d = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < arrayOfa.Length; i++)
            {
                if (userDialogReadA(i)) return;
            }

            Console.WriteLine("Было введено следующее уравнение:");
            for (int i = 0; i < arrayOfa.Length; i++)
            {
                if (i != 0)
                {
                    writeWithColor("+", ConsoleColor.Green, false);
                }
                writeWithColor(arrayOfa[i] + "*X" + i, ConsoleColor.Green, false);
            }
            writeWithColor("=" + d, ConsoleColor.Green);
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }

        static bool userDialogReadA(int i)  //Диалог с пользователем
        {
            Console.Write("A" + i + "=");
            try
            {
                arrayOfa[i] = Int32.Parse(Console.ReadLine());
                if (arrayOfa[i] <= 0)
                {
                    error("Введите положительное число");
                    userDialogReadA(i);
                    return false;
                }
                if (arrayOfa[i] > (d - arrayOfa.Length + 1))
                {
                    if ((d - arrayOfa.Length + 1) < 1)
                    {
                        error("Для данной системы нет решений в целых числах (1)");
                        userDialog();
                        return true;
                    }
                    error("Введите положительное число a <= " + (d - arrayOfa.Length + 1));
                    userDialogReadA(i);
                    return false;
                }
                int sum = arrayOfa.Length - (i + 1);
                for (int k = 0; k <= i; k++)
                {
                    sum += arrayOfa[k];
                }
                if (sum > d)
                {
                    error("Для данной системы нет решений в целых числах (2)");
                    userDialog();
                    return true;
                }
                return false;
            }
            catch
            {
                error("Введите корректное число");
                userDialogReadA(i);
                return false;
            }
        }

        static Member newMember()   //Генерация новой особи
        {
            Random random = new Random();
            Member localMember = null;
            do
            {
                int type = random.Next(0, 6);
                int a = returnMember(random.Next(0, members[membersGenerated - 1].end + 1));
                switch (type)
                {
                    case 0:
                    case 4://Кроссовер (Вероятность х2)
                        int b;
                        do { b = returnMember(random.Next(0, members[membersGenerated - 1].end + 1)); }
                        while (b == a);
                        writeWithColor("Попытка кроссовера " + a + " | " + b, ConsoleColor.Green);
                        localMember = crossOver(ref members[a], ref members[b]);
                        break;
                    case 1: //Мутация (Вероятность х2)
                    case 5:
                        writeWithColor("Попытка мутации " + a, ConsoleColor.Green);
                        localMember = mutation(ref members[a]);
                        break;
                    case 2: //Кроссовер с мутацией
                        int c;
                        do { c = returnMember(random.Next(0, members[membersGenerated - 1].end + 1)); }
                        while (c == a);
                        writeWithColor("Попытка кроссовера с мутацией " + a + " | " + c, ConsoleColor.Green);
                        localMember = crossOver(ref members[a], ref members[c]);
                        writeMember(localMember);
                        writeWithColor(" -> ", ConsoleColor.Yellow);
                        localMember = mutation(ref localMember);
                        break;
                    case 3: //Генерация новой особи
                        writeWithColor("Попытка генерации особи", ConsoleColor.Green);
                        localMember = generation();
                        break;
                }
                writeMember(localMember);
            }
            while (equality(membersGenerated, localMember));
            writeWithColor("Попытка успешна", ConsoleColor.Green);
            membersGenerated++;
            sum += (1 / (double)localMember.survivality); //Подсчитываем сумму для расчета в процентах
            return localMember;
        }

        static int returnMember(int rand)   //Возвращает индекс особи
        {
            for (int i = 0; i < membersGenerated; i++)
            {
                if (members[i].enters(rand)) return i;
            }
            return 0;
        }

        static Member crossOver(ref Member member1, ref Member member2) //Кроссовер
        {
            Random random = new Random();
            int cross = random.Next(0, arrayOfa.Length);
            Member localMember = new Member(member1);
            localMember.x[cross] = member2.x[cross];
            localMember.suitable = 0;
            localMember.updateSurvivality(ref arrayOfa, ref d);
            return localMember;
        }

        static Member mutation(ref Member member)   //Мутация
        {
            Random random = new Random();
            int cross = random.Next(0, arrayOfa.Length);
            Member localMember = new Member(ref arrayOfa, ref d);
            localMember.suitable = 0;
            for (int i = 0; i < localMember.x.Length; i++)
            {
                int type = random.Next(0, 2);
                if (type == 0) localMember.x[i] = member.x[i];
            }
            localMember.updateSurvivality(ref arrayOfa, ref d);
            return localMember;
        }

        static Member generation()  //Генерация
        {
            return new Member(ref arrayOfa, ref d);
        }

        static void firstGeneration()   //Начальная генерация особей
        {
            membersGenerated = (members.Length / percentageOfMembers) + 1;//Подсчет сгенерированных особей
            for (int i = 0; i < membersGenerated; i++) //Процент особей хранится в переменной
            {
                members[i] = new Member(ref arrayOfa, ref d);
                if (i > 0)              //Генерируем только оригинальные особи
                {
                    while (equality(i - 1, members[i]))
                    {
                        members[i] = new Member(ref arrayOfa, ref d);
                    }
                }
                sum += (1 / (double)members[i].survivality); //Подсчитываем сумму для расчета в процентах
            }
        }

        static bool equality(int offset, Member member) //Проверка на оригинальность особи
        {
            for (int i = 0; i < offset; i++)
            {
                bool equality = true;
                for (int j = 0; j < member.x.Length; j++)
                {
                    equality = equality && (members[i].x[j].Equals(member.x[j]));
                }
                if (equality)
                {
                    writeWithColor("Найдено равенство"); //!!!!!!!!!!!!!!!!
                    return equality;
                }
            }
            return false;
        }

        static void foundSolution(int i)
        {
            writeWithColor("Найдено следующее решение:", ConsoleColor.Green);
            writeMember(i, false);
            endTime = DateTime.Now - startTime;
            Console.WriteLine("Решение найдено за:" + endTime);
            Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        static void writeMember(int i, bool full = true) //Вывод особи
        {
            if (full) Console.Write(i + ". ");
            for (int j = 0; j < members[i].x.Length; j++)
            {
                Console.Write(members[i].x[j] + " ");
            }
            if (full)
            {
                Console.Write("|");
                writeWithColor(" " + members[i].survivality, ConsoleColor.Yellow, false);
                Console.Write(" |");
                writeWithColor(" " + members[i].suitable + " %\n", ConsoleColor.Blue, false);

                writeWithColor(members[i].start + " | " + members[i].end + "\n", ConsoleColor.Red, false);
            }
        }

        static void writeMember(Member member, bool full = true) //Вывод особи
        {
            for (int j = 0; j < member.x.Length; j++)
            {
                Console.Write(member.x[j] + " ");
            }
            if (full)
            {
                Console.Write("|");
                writeWithColor(" " + member.survivality, ConsoleColor.Yellow, false);
                Console.Write(" |");
                writeWithColor(" " + member.suitable + " %\n", ConsoleColor.Blue, false);

                writeWithColor(member.start + " | " + member.end + "\n", ConsoleColor.Red, false);
            }
        }

        static void error(string e) //Ошибки
        {
            writeWithColor("Ошибка: " + e + "!");
            writeWithColor("Возобновление диалога с пользователем...");
        }

        static void writeWithColor(string toWrite, ConsoleColor color = ConsoleColor.Red, bool line = true)
        {
            Console.ForegroundColor = color;        //Вывод цветной строки
            if (line) Console.WriteLine(toWrite);
            else Console.Write(toWrite);
            Console.ResetColor();
        }
    }

    class Member
    {
        public int start, end;
        public int[] x;
        public int survivality;
        public double suitable;

        public Member(ref int[] a, ref int d)    //Генерация новой особи в конструкторе
        {
            Random random = new Random();   //Генератор случайных чисел
            x = new int[a.Length];
            survivality = 0;
            suitable = 0;
            for (int i = 0; i < a.Length; i++)
            {
                x[i] = random.Next(1, ((d - a.Length) / a[i]) + 1); //Генерируем хромосомы в пределах возможного значения X
                survivality += x[i] * a[i];                         //Считаем выживаемость
            }
            if (survivality >= d) survivality -= d; //Выживаемость - число положительное
            else survivality = d - survivality;
        }

        public Member(Member input) //Генерация новой особи в конструкторе основе уже существующей
        {
            x = new int[input.x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = input.x[i];
            }
        }

        public void updateSurvivality(ref int[] a, ref int d)
        {
            survivality = 0;
            for (int i = 0; i < a.Length; i++)
            {
                survivality += x[i] * a[i];         //Считаем выживаемость
            }
            if (survivality >= d) survivality -= d; //Выживаемость - число положительное
            else survivality = d - survivality;
        }

        public void updateSuitable(double sum, int previousEnd)
        {
            if (survivality == 0) suitable = 100;
            else suitable = 1.0 / (double)survivality / sum * 100;
            updateStartEnd(previousEnd);
        }

        private void updateStartEnd(int previousEnd) //Присваиваем особи начало и конец для р
        {
            start = previousEnd;
            end = start + (int)(suitable * 1000);
        }

        public bool enters(int gen)
        {
            return (gen > start) && (gen <= end);
        }
    }
}