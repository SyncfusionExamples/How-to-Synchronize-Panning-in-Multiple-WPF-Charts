# How-to-Synchronize-Panning-in-Multiple-WPF-Charts

Synchronizing panning across multiple charts in a WPF application can enhance the user experience by allowing users to view related data simultaneously. This article outlines the steps to achieve synchronized panning in [Syncfusion WPF SfCharts](https://www.syncfusion.com/wpf-controls/charts).

## Steps to achieve Synchronized Panning in Multiple Charts

1. Set Up Multiple Charts

Let’s configure the Syncfusion WPF Chart control using this [getting started documentation](https://help.syncfusion.com/wpf/charts/getting-started). Refer to the following code example to create multiple charts in your application.

 
 ```
<Grid>
. . . .
     <syncfusion:SfChart x:Name="StepLineChart" Grid.Row="0">
             <syncfusion:SfChart.PrimaryAxis>
                 <syncfusion:NumericalAxis />
             </syncfusion:SfChart.PrimaryAxis>
             <syncfusion:SfChart.SecondaryAxis>
                 <syncfusion:NumericalAxis />
             </syncfusion:SfChart.SecondaryAxis>
         <syncfusion:StepLineSeries ItemsSource="{Binding StepLineChartData}" 
                                    XBindingPath="X" 
                                    YBindingPath="Y"
                                    Interior="#9013FE" />
     </syncfusion:SfChart>

     <syncfusion:SfChart x:Name="AreaChart" Grid.Row="1">
             <syncfusion:SfChart.PrimaryAxis>
                 <syncfusion:NumericalAxis />
             </syncfusion:SfChart.PrimaryAxis>
             <syncfusion:SfChart.SecondaryAxis>
                 <syncfusion:NumericalAxis/>
             </syncfusion:SfChart.SecondaryAxis>
         <syncfusion:AreaSeries ItemsSource="{Binding AreaChartData}" 
                                XBindingPath="X" 
                                YBindingPath="Y" 
                                StrokeThickness="20"
                                Interior="#FFB6C1" />
     </syncfusion:SfChart>

     <syncfusion:SfChart x:Name="SplineChart" Grid.Row="2">
             <syncfusion:SfChart.PrimaryAxis>
                 <syncfusion:NumericalAxis/>
             </syncfusion:SfChart.PrimaryAxis>
             <syncfusion:SfChart.SecondaryAxis>
                 <syncfusion:NumericalAxis />
             </syncfusion:SfChart.SecondaryAxis>
         <syncfusion:SplineSeries ItemsSource="{Binding SplineChartData}" 
                                  XBindingPath="X" 
                                  YBindingPath="Y" 
                                  Interior="#8BC34A" />
     </syncfusion:SfChart>
. . . .
 </Grid> 
 ```


2. Enable Zoom Pan behavior for each Chart

The panning feature enables moving the visible area of the chart when zoomed in. To activate panning, set the [**EnablePanning**](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartZoomPanBehavior.html#Syncfusion_UI_Xaml_Charts_ChartZoomPanBehavior_EnablePanning) property to true.

 
 ```
<syncfusion:SfChart>
. . . 

    <syncfusion:SfChart.Behaviors>
        <syncfusion:ChartZoomPanBehavior ZoomMode="X" EnablePanning="True"/>
    </syncfusion:SfChart.Behaviors>

. . .
</syncfusion:SfChart> 
 ```


3.	Handle the Zooming and Panning changed events

This event tracks the changes in the visible area and update the viewports of other charts to match the new range.

[XAML]
 
 ```
<syncfusion:SfChart ZoomChanging="Chart_ZoomChanging" PanChanging="Chart_PanChanging">
. . . 

    <syncfusion:SfChart.Behaviors>
        <syncfusion:ChartZoomPanBehavior ZoomMode="X" EnablePanning="True"/>
    </syncfusion:SfChart.Behaviors>

. . .
</syncfusion:SfChart> 
 ```

[C#]
 
 ```
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
  ```

## Output  

The following demo video illustrates multiple Charts in WPF with synchronized panning, showing how the visible areas of the charts move together when panning is performed on any one chart, following the implemented synchronization steps.

 ![Synchronize_Panning_in_WPF_Multiple_Charts_Converted.gif](https://support.syncfusion.com/kb/agent/attachment/article/18329/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0MDU2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.FobbwZhJqvlfBurJe9ctvqCVvSEnFHXKQrZVGVybq2I)

## Troubleshooting

#### Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For more details, refer to the KB on [how to synchronize panning in WPF chart control?]().