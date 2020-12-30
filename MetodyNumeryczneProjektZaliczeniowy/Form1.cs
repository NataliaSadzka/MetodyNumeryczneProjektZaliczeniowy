using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyNumeryczneProjektZaliczeniowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double CalculateFunctionValueAtX(string[] functionParameters, double pointX)
        {
            double result = 0.0;
            for(int i = 0; i < functionParameters.Length; i++)
            {
                result += Double.Parse(functionParameters[i]) * Math.Pow(pointX , functionParameters.Length - 1 - i);
            }
            
            return result;
        }



        private void calculateButton_Click(object sender, EventArgs e)
        {
            string[] functionParameters = parametersTextBox.Text.Split(',');
            double pointX = Double.Parse(pointXTextBox.Text);
            double result = CalculateFunctionValueAtX(functionParameters, pointX);
            MessageBox.Show(result.ToString());
        }
    }
}
