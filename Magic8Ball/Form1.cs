using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] ans =
        {
            "It is certain.",
            "It is decidedly so.",
            "Without a doubt.",
            "Yes definitely.",
            "You may rely on it.",
            "As I see it, yes.",
            "Most likely.",
            "Outlook good.",
            "Yes.",
            "Signs point to yes.",
            "Reply hazy, try again.",
            "Ask again later.",
            "Better not tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don't count on it.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Very doubtful."
        };
        
        //If the user clicks the background the ball rolls
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Answer.Visible = false; 
            var rand = new Random();
            Thread.Sleep(2000);
            Answer.Visible = true;
            Answer.BringToFront();
            Answer.Text = ans[rand.Next(0, 20)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!button2.Visible){
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button1.Text = @"Hide?";
            }
            else
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button1.Text = @"Stuff?";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xKronos58/Magic8Ball.git");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/xKronos58/FibonacciApplication.git");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}