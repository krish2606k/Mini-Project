using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double fstNum, secNum;
        string oper;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            //7
            if(txtDisplay.Text=="0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            //8
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            //9
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            //4
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            //5
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            //6
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //1
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            //2
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            //3
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            //0
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //+
            fstNum = double.Parse(txtDisplay.Text);
            oper = "+";
            txtDisplay.Text = "";
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            //-
            fstNum = double.Parse(txtDisplay.Text);
            oper = "-";
            txtDisplay.Text = "";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            //*
            fstNum = double.Parse(txtDisplay.Text);
            oper = "*";
            txtDisplay.Text = "";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            //\
            fstNum = double.Parse(txtDisplay.Text);
            oper = "/";
            txtDisplay.Text = "";
        }

        private void BtnPM_Click(object sender, EventArgs e)
        {
            //± 
            double q = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * q);
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            // C
            txtDisplay.Text = "0";
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            // CE
            txtDisplay.Text = "0";

            string f, s;
            f = Convert.ToString(fstNum);
            s = Convert.ToString(secNum);

            f = "";
            s = "";
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            // <x
            if(txtDisplay.Text.Length> 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void BtnEqul_Click(object sender, EventArgs e)
        {
            // =
            secNum = double.Parse(txtDisplay.Text);

            switch(oper)
            {
                case "+":
                    txtDisplay.Text = (fstNum + secNum).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (fstNum - secNum).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (fstNum * secNum).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (fstNum / secNum).ToString();
                    break;

                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
