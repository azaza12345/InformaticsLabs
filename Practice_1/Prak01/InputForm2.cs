using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prak01
{
    public partial class InputForm2 : Form
    {
        public InputForm2()
        {
            InitializeComponent();
        }

        private void submit_Circ_button_Click(object sender, EventArgs e)
        {
            Program.form1.R = int.Parse(textBox1.Text);

            if (radioButton1.Checked) { Program.form1.P = Perimetr(Program.form1.R); }
            if (radioButton2.Checked) { Program.form1.S = Square(Program.form1.R); }

            if (radioButton1.Checked) { Program.form1.design = true; }
            if (radioButton2.Checked) { Program.form1.design = false; }

            this.Close();
        }

        private double Perimetr(double radius)
        {
            return (2 * Math.PI * radius);
        }

        private double Square(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

    }
}
