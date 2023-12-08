using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jetpackGame
{
    public partial class oynanis : Form
    {
        public oynanis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            baslangic baslangic = new baslangic();
            baslangic.Show();
        }

        private void oynanis_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
