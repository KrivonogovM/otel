using System;
using System.Windows.Forms;
using RainbowLight.Resources;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace RainbowLight
{
    public partial class UControl_Statistics : UserControl
    {
        public UControl_Statistics()
        {
            InitializeComponent();
        }

        Dgv dgv = new Dgv();
        public static UControl_Statistics nextPage5;

        public static UControl_Statistics nextPageStatistics
        {
            get
            {
                if (nextPage5 == null)
                {
                    nextPage5 = new UControl_Statistics();
                }
                return nextPage5;
            }
        }

        private void UControl_Statistics_Load(object sender, EventArgs e)
        {
            cartesianChart1.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Values=new LiveCharts.ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,10),
                        new ObservablePoint(4,7),
                        new ObservablePoint(5,3),
                        new ObservablePoint(7,6),
                    },
                    PointGeometrySize=15
                },
                new LineSeries
                {
                    Values=new LiveCharts.ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(2,4),
                        new ObservablePoint(5,7),
                        new ObservablePoint(5,9),
                        new ObservablePoint(9,6),
                    },
                    PointGeometrySize=15
                }
            };
        }
    }
}
