using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Pomodoro_App
{
    public partial class Main : Form
    {
        System.Timers.Timer timer;
        int h, m, s;
        
       

        public Main ()
        {
            InitializeComponent();
        }

        private void buttonpause_Click (object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void buttonreset_Click (object sender, EventArgs e)
        {
            timer.Stop ();
            h = 0;
            m = 0;
            s = 0;
            label1.Text="00:00:00";
        }

        private void buttonsure_Click (object sender, EventArgs e)
        {
            Odaklanma odaklanma = new Odaklanma();
            odaklanma.ShowDialog();

        }

        private void Form1_Load (object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
            

        }
        private void buttonstart_Click (object sender, EventArgs e)
        {
            timer.Start();
        }

        private void OnTimeEvent (object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
               
               

                label1.Text = string.Format("{0}:{1}:{2}",h.ToString().ToString().PadLeft(2,'0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'));
            }));
        }
    }
}
