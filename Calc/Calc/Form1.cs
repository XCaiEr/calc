using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        string sShow;
        double fOld = 0;
        double fNew = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Standerd();
        }

        private void btZero_Click(object sender, EventArgs e)
        {
            if (fNew == 0)
                return;
            fNew *= 10;
            Standerd();
        }

        private void btNum_Click(object sender, EventArgs e)
        {
            string sButton = ((Button)sender).Text;
            fNew = fNew * 10 + Convert.ToInt32(sButton);
            Standerd();
        }

        private void Standerd()
        {
            this.tbScreen.Text = fNew.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            fNew = (long)fNew / 10;
            Standerd();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            fNew = 0;
            Standerd();
        }
    }
}
