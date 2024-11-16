using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Gueesing_game
{
    public partial class Form1 : Form
    {
        Random nums = new Random();
        int count, tama;

        public Form1()
        {
            InitializeComponent();
            tama = nums.Next(1, 11);
            count = 0;
            label2.Text = "Attempts: " + count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hula1 = textBox1.Text;
            int hula;

            if (int.TryParse(hula1, out hula) && hula >= 1 && hula <= 10)
            {
                count++; 
                if (hula == tama)
                {
                    MessageBox.Show("You won!", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    tama = nums.Next(1, 11);
                    Application.Exit();
                   
                }
                else if (hula > tama)
                {
                    MessageBox.Show("baba pa!", "try again", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (hula < tama)
                {
                    MessageBox.Show("taas pa!", "try again", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Sobra kana boss!", "try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label2.Text = "Attempts: " + count;
        }
        



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
