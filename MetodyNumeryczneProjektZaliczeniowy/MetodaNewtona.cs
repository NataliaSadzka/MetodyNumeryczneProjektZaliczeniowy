using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MetodyNumeryczneProjektZaliczeniowy
{
    public partial class MetodaNewtona : Form
    {
        private Wykres wykres;

        public MetodaNewtona()
        {
            InitializeComponent();
            wykres = new Wykres();
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
         * Metoda do wyznaczania stycznej 
         * 
         * @param derivativeFunctionParameters tablica zawierająca parametry pochodnej
         * @param pointX współrzędna x pochodnej
         * @param pointY współrzędna y pochodnej
         * @return wartość stycznej
         */
        public decimal[] CalculateTangent(decimal[] derivativeFunctionParameters, decimal pointX, decimal pointY)
        {
            decimal[] result = new decimal[2];

            decimal derivativeValue = CalculateFunctionValueAtX(derivativeFunctionParameters, pointX);
            result[0] = derivativeValue;

            result[1] = pointY - derivativeValue * pointX;

            return result;
        }

        /**
         * Metoda do wyznaczania miejsca zerowego
         * 
         * @param functionParameters tablica zawierająca parametry wielomianu
         * @param x0 punkt startowy
         * @param epsilon dokładność porównania z zerem
         * @param delta dokładność wyznaczania pierwiastka
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

                decimal[] derivativeParamters = CalculateDerivative(functionParameters);
                decimal fX1 = CalculateFunctionValueAtX(derivativeParamters, x0);
                logRichTextBox.Text += "Pochodna funkcji w potencjalnym miejscu zerowym " + fX1 + "\n";

                decimal[] tangentParameters = CalculateTangent(derivativeParamters, x0, fX0);
                Series series = prepareTangentSeries(tangentParameters, x0, "Styczna " + numberOfIteration);
                wykres.DrawFunctionChart(series);

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
                wykres.DrawPoint(x0, fX0);

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
            wykres.DrawZeroPlace(x0, fX0);

            return x0;     
        }

        /**
         * Metoda sprawdzająca czy miejsce zerowe jest poprawne zgodnie z zadaną dokładnością
         * 
         * @param functionParameters tablica zawierająca parametry wielomianu
         * @param zeroPlace miejsce zerowe
         * @param epsilon dokładność porównania z zerem
         * @return poprawność miejsca zerowego
         */
        public bool IsResultCorrect(decimal[]functionParameters, decimal zeroPlace, decimal epsilon)
        {
            decimal result = CalculateFunctionValueAtX(functionParameters, zeroPlace);

            if(Math.Abs(result) < epsilon)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        /**
         * Metoda
         * @param functionParameters tablica zawierająca parametry wielomianu
         * @param startingPointX punkt startowy
         * @param seriesName nazwa serii
         * @return seria danych do narysowania funkcji
         */
        public Series prepareChartSeries(decimal[] functionParameters, decimal startingPointX, string seriesName)
        {
            Series series = new Series(seriesName);
            for (decimal i = startingPointX - 5.0m; i < startingPointX + 5.0m; i = i + 0.5m)
            {
                series.Points.Add(new DataPoint((double) i, (double) CalculateFunctionValueAtX(functionParameters, i)));
            }
            return series;
        }

        /**
         * Metoda do przygotowania serii danych do rysowania stycznej w punkcie
         * @param functionParameters tablica zawierająca parametry wielomianu
         * @param startingPointX punkt startowy
         * @param seriesName nazwa serii
         * @return seria danych dla stycznej
         */
        public Series prepareTangentSeries(decimal[] functionParameters, decimal startingPointX, string seriesName)
        {
            Series series = new Series(seriesName);
            series.Color = Color.Red;
            for (decimal i = startingPointX - 1.0m; i < startingPointX + 1.0m; i = i + 0.5m)
            {
                series.Points.Add(new DataPoint((double)i, (double)CalculateFunctionValueAtX(functionParameters, i)));
            }
            return series;
        }

        /**
         * Metoda do rozpoczęcia obliczeń
         */
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try //obsługa błędów wprowadzanych danych
            {
                decimal epsilon = Decimal.Parse(epsilonTextBox.Text);
                decimal delta = Decimal.Parse(deltaTextBox.Text);
                int iterations = Int32.Parse(iterationsTextBox.Text);
                decimal[] functionParameters = Array.ConvertAll(parametersTextBox.Text.Split(';'), Decimal.Parse);
                decimal pointX = Decimal.Parse(pointXTextBox.Text);
                decimal zeroPlace = CalculateZeroPlace(functionParameters, pointX, epsilon, delta, iterations);
                zeroPlaceTextBox.Text = zeroPlace.ToString();
                
                Series functionChartSeries = prepareChartSeries(functionParameters, pointX, "funkcja f(x)");

                wykres.DrawFunctionChart(functionChartSeries);
                wykres.Show();
            }
            catch (Exception ex)
            {
            ObslugaBledow Uwaga = new ObslugaBledow();
            Uwaga.Show();
            }
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
            zeroPlaceTextBox.Clear();
        }

        /**
         * Metoda pokazująca okno z informacjami o programie i jest autorach
         */
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_programie O_Programie = new O_programie();
            O_Programie.Show();
        }

        /**
         * Metoda wywołana po kliknięciu przycisku Sprawdź
         */
        private void IsCorrectButton_Click(object sender, EventArgs e)
        {
            decimal[] functionParameters = Array.ConvertAll(parametersTextBox.Text.Split(';'), Decimal.Parse);
            decimal zeroPlace = Decimal.Parse(zeroPlaceTextBox.Text);
            decimal epsilon = Decimal.Parse(epsilonTextBox.Text);
            bool correctResult = IsResultCorrect(functionParameters, zeroPlace, epsilon);

            if(correctResult)
            {
                MessageBox.Show("Miejsce zerowe jest poprawne");
            }
            else
            {
                MessageBox.Show("Miejsce zerowe nie spełnia kryterium poprawności");
            }
        }

        /**
         * Metoda pokazująca okno ze schematem do wprowadzania danych
         */
        private void SchematWprowadzaniaDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchematObsługiBledow schematObslugiBledow = new SchematObsługiBledow();
            schematObslugiBledow.Show();
        }
    }
}
