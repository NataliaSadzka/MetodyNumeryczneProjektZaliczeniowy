using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MetodyNumeryczneProjektZaliczeniowy
{
    public partial class Wykres : Form
    {
        private Series potentialZeroPlaces;

        /**
         * Konstruktor klasy 
         * Inicjuje serię danych dla potencjalnych miejsc zerowych 
         * Tworzy opis wykresu 
         */
        public Wykres()
        {
            InitializeComponent();
            ResetChart();

            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.MouseWheel += Chart1_MouseWheel;

            Title title = chart1.Titles.Add("Metoda Newtona");
            chart1.ChartAreas[0].AxisX.Title = "Oś x";
            chart1.ChartAreas[0].AxisY.Title = "Oś y";
        }

        /**
         * Metoda do rysowania funkcji na wykresie
         * 
         * @param series seria danych do narysowania 
         */
        public void DrawFunctionChart(Series series)
        {
            series.ChartType = SeriesChartType.Spline;
            chart1.Series.Add(series);
        }

        /**
         * Metoda do rysowania potencjalnych miejsc zerowych
         * 
         * @param pointX współrzędna x kolejnego potencjalnego miejsca zerowego
         * @param pointY współrzędna y kolejnego potencjalnego miejsca zerowego
         */
        public void DrawPoint(decimal pointX, decimal pointY)
        {
            potentialZeroPlaces.Points.AddXY(pointX, pointY);         
        }

        /**
         * Metoda do rysowania miejsca zerowego
         * 
         * @param pointX współrzędna x miejsca zerowego
         * @param pointY współrzędna y miejsca zerowego
         */
        public void DrawZeroPlace(decimal pointX, decimal pointY)
        {
            Series series = new Series("Miejsce zerowe");
            series.Points.AddXY(pointX, pointY);
            series.ChartType = SeriesChartType.Point;
            series.Color = Color.Black;
            chart1.Series.Add(series);
        }

        /**
         * Metoda, która umożliwia przybliżanie i oddalanie wykresu
         * 
         * Link: https://stackoverflow.com/questions/13584061/how-to-enable-zooming-in-microsoft-chart-control-by-using-mouse-wheel
         */
        private void Chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }
        public void ResetChart()
        {
            chart1.Series.Clear();
            potentialZeroPlaces = new Series("Potencjalne miejsca zerowe");
            potentialZeroPlaces.ChartType = SeriesChartType.Point;
            potentialZeroPlaces.Color = Color.Green;
            chart1.Series.Add(potentialZeroPlaces);
        }
    }
}
