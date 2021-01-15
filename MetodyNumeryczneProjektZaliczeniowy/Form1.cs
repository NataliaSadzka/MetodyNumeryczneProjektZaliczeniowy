﻿using System;
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

        /**
         * Metoda do wyliczania funkcji w punkcie
         * 
         * @param functionParameters tablica zawierająca parametry wielomianu
         * @param pointX punkt dla którego będziemy wyznaczać wartość funkcji
         * @return wartość funkcji w zadanym punkcie
         */
        public decimal CalculateFunctionValueAtX(decimal[] functionParameters, decimal pointX)
        {
            decimal result = 0.0m;
            for(int i = 0; i < functionParameters.Length; i++)
            {
                result += functionParameters[i] * (decimal)Math.Pow((double)pointX , functionParameters.Length - 1 - i);
            }
            return result;
        }


        /**
         * Metoda do wyznaczania pochodnej funkcji
         * 
         * @param functionParameters tablica zawierająca parametry wielomianu
         * @return wartość wartość pochodnej funkcji
         */
        public decimal[] CalculateDerivative(decimal[] functionParameters)
        {
            decimal[] result = new decimal[functionParameters.Length - 1];
          
            for (int i = 0; i < functionParameters.Length - 1; i++)
            {
                result[i] = functionParameters[i] * (functionParameters.Length - 1 - i);
            }
            return result;
        }

        /**
         * Metoda do wyznaczania miejsca zerowego
         * 
         * @param functionParameters tablica zawierająca parametry wielomianu
         * @param x0 punkt startowy
         * @param epsilon dokładność porównania z zerem
         * @param epsilon dokładność wyznaczania pierwiastka
         * @param iterations maksymalna wartość iteracji jaką program może wykonać
         * @return wartość miejsca zerowego
         */
        public decimal CalculateZeroPlace(decimal[] functionParameters, decimal x0, decimal epsilon, decimal delta, int iterations)
        {
            logRichTextBox.Text += "Rozpoczęto obliczenia \n";
            logRichTextBox.Text += "Funkcja wejściowa " + String.Join(";", functionParameters) + "\n";
            logRichTextBox.Text += "Punkt startowy " + x0 + "\n";
            
            decimal x1 = x0 - 1;
            decimal fX0 = CalculateFunctionValueAtX(functionParameters, x0);

            logRichTextBox.Text += "Wartość funkcji w punkcie startowym " + fX0 + "\n";

            logRichTextBox.Text += "Dokładność porównania z zerem " + epsilon + "\n";
            logRichTextBox.Text += "Dokładność wyznaczania pierwiastka " + delta + "\n";
            logRichTextBox.Text += "Maksymalna wartość iteracji " + iterations + "\n";

            int numberOfIteration = 0;

            while (iterations > 0 && Math.Abs(x1 - x0) > epsilon && Math.Abs(fX0) > delta) //wykonuj dopóki liczba iteracji jest większa od 0 i wartość bezwzględna z x1 - x0 jest większa od epsilon i wartość bezwzględna z funkcji w punkcie x0 jest większa od delta
            {
                logRichTextBox.Text += "\n";
                numberOfIteration += 1;
                logRichTextBox.Text += "Numer iteracji " + numberOfIteration + "\n";

                decimal fX1 = CalculateFunctionValueAtX(CalculateDerivative(functionParameters), x0);
                logRichTextBox.Text += "Pochodna funkcji w potencjalnym miejscu zerowym " + fX1 + "\n";

                if (Math.Abs(fX1) < delta) //sprawdzenie czy wartość funkcji od bieżącego przybliżenia miejsca zerowego jest mniejsza od przyjętej wartości delty
                {
                    MessageBox.Show("Zly punkt startowy");
                    break;
                }

                x1 = x0;
                x0 = x0 - fX0 / fX1;

                logRichTextBox.Text += "Potencjalne miejsce zerowe " + x0 + "\n";
                fX0 = CalculateFunctionValueAtX(functionParameters, x0);

                logRichTextBox.Text += "Wartość funkcji w potencjalnym miejscu zerowym " + fX0 + "\n";

                iterations = iterations - 1;
                logRichTextBox.Text += "Pozostało iteracji " + iterations + "\n";
            }

            if (iterations == 0) //sprawdzenie czy osiągnięto maksymalną liczbę iteracji
            {
                MessageBox.Show("Przekroczony limit obiegów");
            }

            logRichTextBox.Text += "\n";
            logRichTextBox.Text += "Zakończono obliczenia " + "\n";
            logRichTextBox.Text += "Miejsce zerowe to " + x0 + "\n";

            return x0;     
        }

        /**
         * Metoda do rozpoczęcia obliczeń
         */
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal epsilon = Decimal.Parse(epsilonTextBox.Text);
            decimal delta = Decimal.Parse(deltaTextBox.Text);
            int iterations = Int32.Parse(iterationsTextBox.Text);

            decimal[] functionParameters = Array.ConvertAll(parametersTextBox.Text.Split(';'), Decimal.Parse);
            decimal pointX = Decimal.Parse(pointXTextBox.Text);

            decimal zeroPlace = CalculateZeroPlace(functionParameters, pointX, epsilon, delta, iterations);
        }

        /**
         * Metoda do resetowania wpisanych przez użytkownika wartości 
         */
        private void resetButton_Click(object sender, EventArgs e)
        {
            parametersTextBox.Clear();
            pointXTextBox.Clear();
            epsilonTextBox.Text = "0,000001";
            deltaTextBox.Text = "0,000001";
            iterationsTextBox.Text = "100";
        }

        /**
         * Metoda pokazująca okno z informacjami o programie i jest autorach
         */
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_programie O_Programie = new O_programie();
            O_Programie.Show();
        }    
    }
}
