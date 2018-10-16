using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;

namespace WinFormScientificCalculator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 315;
            txtDisplay.Width = 274;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 615;
            txtDisplay.Width = 570;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 315;
            txtDisplay.Width = 274;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
            {
                txtDisplay.Text = "";
            }

            enter_value = false;
            Button num = (Button)sender;

            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + num.Text;
                }
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void ArithmaticOpt_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShowOp.Text = Convert.ToString(results) + " " + operation;
        }

        private void btnEqueal_Click(object sender, EventArgs e)
        {

            lblShowOp.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = results;
                    txtDisplay.Text = (Math.Exp(i * Math.Log(q * 4))).ToString();
                    break;
            }
            
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.PI.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("Log " + "(" + (txtDisplay.Text) + ")");

            iLog = Math.Log10(iLog);

            txtDisplay.Text = Convert.ToString(iLog);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("Log " + "(" + (txtDisplay.Text) + ")");

            sq = Math.Sqrt(sq);

            txtDisplay.Text = Convert.ToString(sq);

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("Sin " + "(" + (txtDisplay.Text) + ")");

            sin = Math.Sin(sin);
            txtDisplay.Text = Convert.ToString(sin);

        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("Cos " + "(" + (txtDisplay.Text) + ")");

            cos = Math.Cos(cos);
            txtDisplay.Text = Convert.ToString(cos);

        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("Tan " + "(" + (txtDisplay.Text) + ")");

            tan = Math.Tan(tan);
            txtDisplay.Text = Convert.ToString(tan);
        }

        private void btnNfactorial_Click(object sender, EventArgs e)
        {
            double fact = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("Tan " + "(" + (txtDisplay.Text) + ")");

            fact = MathNet.Numerics.SpecialFunctions.Factorial((int)fact);
            txtDisplay.Text = Convert.ToString(fact);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a, 8);
        }

        private void btnXPow2_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a);

        }

        private void btnXPow3_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a);
        }

        private void btnOneByX_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text) );
            txtDisplay.Text = Convert.ToString(a);
        }

        private void btnInX_Click(object sender, EventArgs e)
        {
            double iLog = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = Convert.ToString("In" + "(" + (txtDisplay.Text) + ")");

            iLog = Math.Log(iLog);

            txtDisplay.Text = Convert.ToString(iLog);
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) / 100;
            txtDisplay.Text = Convert.ToString($"{a :0.00}");
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 100);
            txtDisplay.Text = Convert.ToString(a);

        }

        private void btnTenX_Click(object sender, EventArgs e)
        {
            Double a;
            a = Math.Pow(10, Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = Convert.ToString(a);
        }
    }
}
