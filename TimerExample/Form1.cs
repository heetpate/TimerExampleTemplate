using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace TimerExample
{
    public partial class Form1 : Form
    {
        int counter = 0;
        Stopwatch myWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (countTimer.Enabled == false)
            {
                countTimer.Start();
                startButton.Text = "Pause";
            }
            else 
            {
                countTimer.Stop();
                startButton.Text = "Start";

                myWatch.Stop();
                //timerOutput.Text = myWatch.Elapsed + "";
                //timerOutput.Text = myWatch.ElapsedMilliseconds + "";
                timeOutput.Text = myWatch.Elapsed.ToString(@"ss.\ff");
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void countTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            counterLabel.Text = $"{counter}";

            if (colourLabel.BackColor == Color.White)
            {
                colourLabel.BackColor = Color.DodgerBlue;
               
            }
            else if (colourLabel.BackColor == Color.DodgerBlue)
            {
                colourLabel.BackColor = Color.White;

            }
        }
    }
}
