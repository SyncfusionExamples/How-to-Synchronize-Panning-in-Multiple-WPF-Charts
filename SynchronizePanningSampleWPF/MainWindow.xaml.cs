namespace SynchronizePanningSampleWPF
{
    using Syncfusion.UI.Xaml.Charts;
    using System.Windows;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Chart_ZoomChanging(object sender, ZoomChangingEventArgs e)
        {
            SfChart sourceChart = (SfChart)sender;
            foreach (var chart in new[] { StepLineChart, SplineChart, AreaChart })
            {
                if (chart != sourceChart)
                {
                    chart.PrimaryAxis.ZoomFactor = e.CurrentFactor;
                    chart.PrimaryAxis.ZoomPosition = e.CurrentPosition;
                }
            }
        }

        private void Chart_PanChanging(object sender, PanChangingEventArgs e)
        {
            SfChart sourceChart = (SfChart)sender;
            foreach (var chart in new[] { StepLineChart, SplineChart, AreaChart })
            {
                if (chart != sourceChart)
                {
                    chart.PrimaryAxis.ZoomPosition = e.NewZoomPosition;
                    chart.PrimaryAxis.ZoomFactor = e.Axis.ZoomFactor;
                }
            }
        }
    }
}