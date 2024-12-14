namespace SynchronizePanningSampleWPF
{
    using System.Collections.ObjectModel;

    public class ChartViewModel
    {
        public ObservableCollection<ChartData> StepLineChartData { get; set; }
        public ObservableCollection<ChartData> SplineChartData { get; set; }
        public ObservableCollection<ChartData> AreaChartData { get; set; }

        public ChartViewModel()
        {
            // Data for StepLine Chart
            StepLineChartData = new ObservableCollection<ChartData>()
            {
                new ChartData { X = 0, Y = 4 },
                new ChartData { X = 1, Y = 6 },
                new ChartData { X = 2, Y = 5 },
                new ChartData { X = 3, Y = 8 },
                new ChartData { X = 4, Y = 10 },
                new ChartData { X = 5, Y = 7 },
                new ChartData { X = 6, Y = 12 },
                new ChartData { X = 7, Y = 9 },
                new ChartData { X = 8, Y = 11 },
                new ChartData { X = 9, Y = 6 },
                new ChartData { X = 10, Y = 8 },
                new ChartData { X = 11, Y = 10 },
                new ChartData { X = 12, Y = 13 },
                new ChartData { X = 13, Y = 9 },
                new ChartData { X = 14, Y = 14 }
            };

            // Data for Spline Chart
            SplineChartData = new ObservableCollection<ChartData>()
            {
                new ChartData { X = 0, Y = 3 },
                new ChartData { X = 1, Y = 5 },
                new ChartData { X = 2, Y = 4 },
                new ChartData { X = 3, Y = 6 },
                new ChartData { X = 4, Y = 8 },
                new ChartData { X = 5, Y = 7 },
                new ChartData { X = 6, Y = 9 },
                new ChartData { X = 7, Y = 6 },
                new ChartData { X = 8, Y = 10 },
                new ChartData { X = 9, Y = 12 },
                new ChartData { X = 10, Y = 8 },
                new ChartData { X = 11, Y = 11 },
                new ChartData { X = 12, Y = 13 },
                new ChartData { X = 13, Y = 10 },
                new ChartData { X = 14, Y = 14 }
            };

            // Data for Area Chart
            AreaChartData = new ObservableCollection<ChartData>()
            {
                new ChartData { X = 0, Y = 5 },
                new ChartData { X = 1, Y = 7 },
                new ChartData { X = 2, Y = 6 },
                new ChartData { X = 3, Y = 9 },
                new ChartData { X = 4, Y = 11 },
                new ChartData { X = 5, Y = 8 },
                new ChartData { X = 6, Y = 10 },
                new ChartData { X = 7, Y = 7 },
                new ChartData { X = 8, Y = 12 },
                new ChartData { X = 9, Y = 9 },
                new ChartData { X = 10, Y = 11 },
                new ChartData { X = 11, Y = 13 },
                new ChartData { X = 12, Y = 15 },
                new ChartData { X = 13, Y = 12 },
                new ChartData { X = 14, Y = 14 }
            };
        }
    }
}
