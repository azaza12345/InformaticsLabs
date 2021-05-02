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
    public partial class Reverse : Form
    {
        public string normalText;
        public string newText;

        public Reverse()
        {
            InitializeComponent();
        }

        private void submit_Rect_button_Click(object sender, EventArgs e)
        {
            normalText = textBox1.Text;

            if (radioButton1.Checked) { newText = UpperCase(normalText); }
            if (radioButton2.Checked) { newText = ReverseText(normalText); }

            textBox1.Text = newText;
        }

        private string UpperCase(string text)
        {
            return text.ToUpper();
        }

        private string ReverseText(string text)
        {
            char[] reverseText = text.ToCharArray();
            Array.Reverse(reverseText);
            return new string(reverseText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
