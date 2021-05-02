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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void submit_Rect_button_Click(object sender, EventArgs e)
        {
            try
            {
                Program.form1.A = int.Parse(textBox1.Text);
                Program.form1.B = int.Parse(textBox2.Text);
            }
            catch (Exception exeption)
            {
                Program.form1.A = -1; Program.form1.B = -1;
            }

            if (radioButton1.Checked) { Program.form1.rect_color = Color.Red; }
            if (radioButton2.Checked) { Program.form1.rect_color = Color.Green; }
            if (radioButton3.Checked) { Program.form1.rect_color = Color.Blue; }

            this.Close();
        }

    }
}
