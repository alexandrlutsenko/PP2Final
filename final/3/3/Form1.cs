using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            cnt++;
            Button btn = sender as Button;
            if(cnt%2 == 0)
            {
                btn.Text = "O";
                btn.Enabled = false;
            }
            else
            {
                btn.Text = "X";
                btn.Enabled = false;
            }

            if(cnt >= 5)
            {
                if(button5.Enabled == false && (button5.Text == button1.Text && button5.Text == button9.Text)|| (button5.Text == button3.Text && button5.Text == button7.Text)||
                    (button5.Text == button4.Text && button5.Text == button6.Text)|| (button5.Text == button2.Text && button5.Text == button8.Text))
                    {
                        MessageBox.Show(button5.Text + " wins");
                        Close();
                    }
                if (button1.Enabled == false && (button1.Text == button4.Text && button1.Text == button7.Text)|| (button1.Text == button2.Text && button1.Text == button3.Text))
                    {
                        MessageBox.Show(button1.Text + " wins");
                        Close();
                    }
                if (button9.Enabled == false && (button9.Text == button8.Text && button9.Text == button7.Text)|| (button9.Text == button6.Text && button9.Text == button3.Text))
                    {
                        MessageBox.Show(button9.Text + " wins");
                        Close();
                    }
            }

            if(cnt >= 9)
            {
                MessageBox.Show("Game Over");
                Close();
            }
        }
    }
}
