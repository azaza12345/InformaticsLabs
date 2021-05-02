using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Prak01
{
    public partial class Form1 : Form
    {
        public int A, B, R;
        public Color rect_color;
        public double S, P;
        public bool design;

        Panel rectangle = new Panel();

        public Form1()
        {
            Program.form1 = this;
            InitializeComponent();
            main.Controls.Add(rectangle);
        }

        private void size_button_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.Show();
            rectangle_button.Enabled = true;
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            message.Text = "Эта программа написана Логвиновым Львом\nгруппа К3220";
            rectangle.Visible = false;
            message.Visible = true;
        }

        private void rectangle_button_Click(object sender, EventArgs e)
        {
            int maxSize = main.Width;
            
            if (A > 0 & B > 0 & A <= maxSize & B <= maxSize)
            {
                rectangle.Size = new Size(A, B);
                rectangle.BackColor = rect_color;
                message.Visible = false;
                rectangle.Visible = true;
            }
            else
            {
                message.Text = "Вы ввели недопустимый размер";
                rectangle.Visible = false;
                message.Visible = true;
            }
        }

        private void calc_button_Click(object sender, EventArgs e)
        {
            if (design) { MessageBox.Show($"P = {P}"); }
            else { MessageBox.Show($"S = {S}"); }
        }

        private void circle_button_Click(object sender, EventArgs e)
        {
            if (R <= 350)
            {
                rectangle.Visible = false;
                Pen pen = new Pen(Brushes.Black);
                Rectangle rect = new Rectangle(0, 0, R, R);
                Graphics graph = main.CreateGraphics();

                graph.DrawEllipse(pen, rect);
            }
            else
            {
                message.Text = "Вы ввели недопустимый размер";
                rectangle.Visible = false;
                message.Visible = true;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reverse reverse = new Reverse();
            reverse.Show();
        }

        private void input_button_Click(object sender, EventArgs e)
        {
            InputForm2 inputForm2 = new InputForm2();
            inputForm2.Show();
            circle_button.Enabled = true;
            calc_button.Enabled = true;
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
