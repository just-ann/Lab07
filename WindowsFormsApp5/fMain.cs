using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) ||
(String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!";
                return;
            }
            double x1 = double.Parse(tbX1.Text);
            double x2 = double.Parse(tbX2.Text);
            double y = (x1 + x2)/2;
            tbY.Text = y.ToString("0.####");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h=0.1,a=-1000,b=1000,f;
            this.chart1.Series[0].Points.Clear();
            double x1= 3;
            double x2 = 2;
          
            while(x1<=b)
            {
                f = (Math.Sqrt(Math.Pow(Math.Cos(x1),3)+x2))/(Math.Pow(x1,13)+(3)/(Math.Cos(x2)));
                this.chart1.Series[0].Points.AddXY(x1, x2);
                x1 += h;
            }
        }
    }
}
