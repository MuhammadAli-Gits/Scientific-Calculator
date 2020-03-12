using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sci_Cal
{
    public partial class Calculator : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        float Celsius, Fehrenhiet;
        char iOperation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 300;
            txtDisplay.Width = 261;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 583;
            txtDisplay.Width = 543;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Enabled = false;
            this.Width = 300;
            txtDisplay.Width = 261;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Width = 1001;
            txtDisplay.Width = 543;
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1001;
            txtDisplay.Width = 543;
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1313;
            txtDisplay.Width = 543;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text=="0") || (enter_value))
                txtDisplay.Text="";
            enter_value=false;
            Button num=(Button)sender;
            if (num.Text==".")
	{
		 if(!txtDisplay.Text.Contains("."))
             txtDisplay.Text=txtDisplay.Text + num.Text;
	}
            else
                txtDisplay.Text =txtDisplay.Text +num.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblshowop.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblshowop.Text = "";
           // abc = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length>0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text=="")
            {
                txtDisplay.Text = "0";
            }
        }
        Double abc = 0;
        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtDisplay.Text);
           
            abc = abc + results;
            txtDisplay.Text = "";
            lblshowop.Text = lblshowop.Text + "" + Convert.ToString(results) + " " + operation;
           
          
        }
       
        private void button19_Click(object sender, EventArgs e)
        {
            lblshowop.Text = "";
            switch (operation)
            {
                case"+":
                  //  txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    txtDisplay.Text = ( abc+ Double.Parse(txtDisplay.Text)).ToString();
                   
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
                case"Exp":
                    double i = Double.Parse(txtDisplay.Text);
                    double q;
                    q = (results);
                    txtDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "3.141592653589976323";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblshowop.Text = Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = Convert.ToString(ilog);
            

        }

        private void button31_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(txtDisplay.Text);
            lblshowop.Text = Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")");
            sqrt = Math.Sqrt(sqrt);
            txtDisplay.Text = Convert.ToString(sqrt);
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double sinh = Double.Parse(txtDisplay.Text);
            lblshowop.Text = Convert.ToString("Sinh" + "(" + (txtDisplay.Text) + ")");
            sinh = Math.Sinh(sinh);
            txtDisplay.Text = Convert.ToString(sinh);
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(txtDisplay.Text);
            lblshowop.Text = System.Convert.ToString("Sin" + "(" + (txtDisplay.Text) + ")");
            sin = Math.Sin(sin);
            txtDisplay.Text = Convert.ToString(sin);
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double cosh = Double.Parse(txtDisplay.Text);
            lblshowop.Text = Convert.ToString("Cosh" + "(" + (txtDisplay.Text) + ")");
            cosh = Math.Cosh(cosh);
            txtDisplay.Text = Convert.ToString(cosh);
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(txtDisplay.Text);
            lblshowop.Text = Convert.ToString("Cos" + "(" + (txtDisplay.Text) + ")");
            cos = Math.Cos(cos);
            txtDisplay.Text = Convert.ToString(cos);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double tanh = Double.Parse(txtDisplay.Text);
            lblshowop.Text = Convert.ToString("Tanh" + "(" + (txtDisplay.Text) + ")");
            tanh = Math.Tanh(tanh);
            txtDisplay.Text = Convert.ToString(tanh);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(txtDisplay.Text);
            lblshowop.Text = Convert.ToString("Tan" + "(" + (txtDisplay.Text) + ")");
            tan = Math.Tan(tan);
            txtDisplay.Text = Convert.ToString(tan);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a, 2);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a, 16);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a, 8);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(a);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtDisplay.Text);
            int i;
            for (i = a - 1; i > 0; i--)
            {
                a = a * i;
            }
            txtDisplay.Text = Convert.ToString(a);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblshowop.Text = Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log(ilog);
            txtDisplay.Text = Convert.ToString(ilog);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
            txtDisplay.Text = Convert.ToString(a);
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
         private void button41_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    Celsius= float.Parse(textBox1.Text);
                    label1.Text=((((9*Celsius/5)+32).ToString()));
                    break;
                case 'F':
                    Fehrenhiet =float.Parse(textBox1.Text);
                    label1.Text=((((Fehrenhiet-32)*5)/9).ToString());
                    break;
               

            }

        }

         private void button42_Click(object sender, EventArgs e)
         {
             textBox1.Clear();
             label1.Text = "";
             rbCelToFeh.Checked = false;
             rbFehToCel.Checked = false;
            

         }

         private void btnMultiply_Click(object sender, EventArgs e)
         {
            
         }
        
         private void button4_Click(object sender, EventArgs e)
         {
            
         }

         private void Form1_KeyDown(object sender, KeyEventArgs e)
         {
            
         }
    }
}

