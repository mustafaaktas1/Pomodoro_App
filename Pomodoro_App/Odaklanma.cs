using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro_App
{
    public partial class Odaklanma : Form
    {
        int h, m, s = 0;

        public Odaklanma ()
        {
            InitializeComponent();
        }

        private void Odaklanma_Load (object sender, EventArgs e)
        {

        }

        private void buttononay_Click (object sender, EventArgs e)
        {

        }

        void NumberOnly (object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        void NumberDetect (object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            else if (e.KeyChar == '\b')
            {
                if (textBox.Text.Length == 1)
                {
                    textBox.Text = "";
                }
                else
                {
                    textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                }
            }
            else
            {
                int value;
                if (int.TryParse(textBox.Text + e.KeyChar, out value) && value > 59)
                {
                    e.Handled = true;
                }
            }
        }


    }
}
