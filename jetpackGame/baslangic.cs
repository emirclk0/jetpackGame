using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jetpackGame
{
    public partial class baslangic : Form
    {
        public int renk = 0;
        public baslangic()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void baslangic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void gametextTimer_Tick(object sender, EventArgs e)
        {
            List<Color> list = new List<Color>();
            list.Add((Color.Blue));
            list.Add((Color.Green));
            list.Add((Color.Red));
            list.Add((Color.Yellow));
            list.Add((Color.Orange));
            list.Add((Color.Orchid));
            list.Add((Color.Pink));
            list.Add((Color.Purple));
            if (renk < 8)
            {
                label1.ForeColor = list[renk];
                renk++;
            }
            else
            {
                renk = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            oynanis oynanis = new oynanis();
            oynanis.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
