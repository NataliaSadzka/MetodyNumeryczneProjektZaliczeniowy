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

        public static decimal CalculateFunctionValueAtX(decimal[] functionParameters, decimal pointX)
        {
            decimal result = 0.0m;
            for(int i = 0; i < functionParameters.Length; i++)
            {
                result += functionParameters[i] * (decimal)Math.Pow((double)pointX , functionParameters.Length - 1 - i);
            }
            return result;
        }

        public decimal[] CalculateDerivative(decimal[] functionParameters)
        {
            decimal[] result = new decimal[functionParameters.Length - 1];
          
            for (int i = 0; i < functionParameters.Length - 1; i++)
            {
                result[i] = functionParameters[i] * (functionParameters.Length - 1 - i);
            }
            return result;
        }

        public decimal CalculateZeroPlace(decimal[] functionParameters, decimal startPointX, decimal epsilon, decimal delta, int iterations)
        {
            logRichTextBox.Text += "Rozpoczęto obliczenia \n";
            logRichTextBox.Text += "Funkcja wejściowa " + String.Join(";", functionParameters) + "\n";
            logRichTextBox.Text += "Punkt startowy " + startPointX + "\n";
            
            decimal x1 = startPointX - 1;
            decimal fX0 = CalculateFunctionValueAtX(functionParameters, startPointX);

            logRichTextBox.Text += "Wartość funkcji w punkcie startowym " + fX0 + "\n";

            logRichTextBox.Text += "Dokładność porównania z zerem " + epsilon + "\n";
            logRichTextBox.Text += "Dokładność wyznaczania pierwiastka " + delta + "\n";
            logRichTextBox.Text += "Maksymalna wartość iteracji " + iterations + "\n";

            int numberOfIteration = 0;

            while (iterations > 0 && Math.Abs(x1 - startPointX) > delta && Math.Abs(fX0) > epsilon)
            {
                logRichTextBox.Text += "\n";
                numberOfIteration += 1;
                logRichTextBox.Text += "Numer iteracji " + numberOfIteration + "\n";

                decimal fX1 = CalculateFunctionValueAtX(CalculateDerivative(functionParameters), startPointX);
                logRichTextBox.Text += "Pochodna funkcji w potencjalnym miejscu zerowym " + fX1 + "\n";

                if (Math.Abs(fX1) < epsilon)
                {
                    MessageBox.Show("Zly punkt startowy");
                    break;
                }

                x1 = startPointX;
                startPointX = startPointX - fX0 / fX1;

                logRichTextBox.Text += "Potencjalne miejsce zerowe " + startPointX + "\n";
                fX0 = CalculateFunctionValueAtX(functionParameters, startPointX);

                logRichTextBox.Text += "Wartość funkcji w potencjalnym miejscu zerowym " + fX0 + "\n";

                iterations = iterations - 1;
                logRichTextBox.Text += "Pozostało iteracji " + iterations + "\n";
            }

            if (iterations == 0)
            {
                MessageBox.Show("Przekroczony limit obiegów");
            }

            logRichTextBox.Text += "\n";
            logRichTextBox.Text += "Zakończono obliczenia " + "\n";
            logRichTextBox.Text += "Miejsce zerowe to " + startPointX + "\n";

            return startPointX;     
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal epsilon = Decimal.Parse(epsilonTextBox.Text);
            decimal delta = Decimal.Parse(deltaTextBox.Text);
            int iterations = Int32.Parse(iterationsTextBox.Text);

            decimal[] functionParameters = Array.ConvertAll(parametersTextBox.Text.Split(';'), Decimal.Parse);
            decimal pointX = Decimal.Parse(pointXTextBox.Text);

            decimal zeroPlace = CalculateZeroPlace(functionParameters, pointX, epsilon, delta, iterations);
            //MessageBox.Show(zeroPlace.ToString());
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            parametersTextBox.Clear();
            pointXTextBox.Clear();
            epsilonTextBox.Text = "0,000001";
            deltaTextBox.Text = "0,000001";
            iterationsTextBox.Text = "100";
        }

        

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_programie O_Programie = new O_programie();
            O_Programie.Show();
        }

        
    }
}
