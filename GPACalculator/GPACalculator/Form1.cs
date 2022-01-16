using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class Form1 : Form
    {
        //double sum = 0.0;
        //int n = 0;
        //double max = 0; 
        GPACalculator oGPACal = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////4.00
            //string strInput = textBoxGPA_input.Text;
            //double dInput = double.Parse(strInput);
            //if (dInput > max)
            //max = dInput;

            ////sum = 0.0 + "4.00"
            //sum = sum + dInput;
            //n = n + 1;
            ////convert double to strInput and settext to textBox
            //double result = sum / n;
            //textBoxGPAX.Text = result.ToString();
            //textBoxGPA_input.Text = "";
            //textBoxMaxGPA.Text = max.ToString();

            ///create object
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;

            double dInput = Convert.ToDouble(input);
            oGPACal.addGPA(dInput, name);

            double gpax = oGPACal.getGPAx();
            textBoxGPAX.Text = gpax.ToString();
            ///MaxGPA
            double max = oGPACal.getMax();
            textBoxMaxGPA.Text = max.ToString();
            textBoxMaxName.Text = oGPACal.getMaxName().ToString();
            ///MinGPA
            double min = oGPACal.getMin();
            textBoxMinGPA.Text = min.ToString();
            textBoxMinName.Text = oGPACal.getMinName().ToString();
            ///GPA Name User
            textBoxGPA_input.Text = "";
            textBoxName_input.Text = string.Empty;
            textBoxAllData.Text = oGPACal.getAllData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAX.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxMinGPA.Text = "";
            textBoxMaxName.Text = "";
            textBoxMinName.Text = "";
            textBoxName_input.Text = "";
            textBoxAllData.Text = "";
            //sum = 0;
            //n = 0;
        }
    }
}
