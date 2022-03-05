using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302200016
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int jumlahkan;
        Boolean jumlahkanAkhir = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay2.Text = "+";
            txtDisplay.Text = " ";
            jumlahkan = 4;
            jumlahkanAkhir = true;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(jumlahkanAkhir == true)
                bil2 = Convert.ToDecimal(txtDisplay.Text);
            {
                switch(jumlahkan)
                {
                    case 1:
                        txtDisplay.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                jumlahkanAkhir = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "2";
                }
                else
                {
                    txtDisplay.Text += "2";
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "3";
                }
                else
                {
                    txtDisplay.Text += "3";
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "4";
                }
                else
                {
                    txtDisplay.Text += "4";
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "5";
                }
                else
                {
                    txtDisplay.Text += "5";
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "6";
                }
                else
                {
                    txtDisplay.Text += "6";
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "7";
                }
                else
                {
                    txtDisplay.Text += "7";
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "8";
                }
                else
                {
                    txtDisplay.Text += "8";
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = "9";
                }
                else
                {
                    txtDisplay.Text += "9";
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            {
                if (txtDisplay.Text != "0")
                {
                    txtDisplay.Text += "0";
                }
            }
        }
    }
}
