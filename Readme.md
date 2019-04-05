<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->
# How to remove highlighting of the current day header and alternate cell color


<p><strong>Problem:</strong></p><p></p><p>By default my SchedulerControl is displayed as follows:</p><p></p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-remove-highlighting-of-the-current-day-header-and-alternate-cell-color-e4747/12.2.10+/media/674ed945-18f2-4540-9432-77980e02da12.png"></p><p></p><p>Note that the current day header and worktime cell area are highlighted. I want to disable this highlighting for all views. </p><p></p><p><strong>Solution:</strong></p><p></p><p>These elements are rendered according to the alternate styles and background brush selectors accordingly. You can examine the default themes (see the C:\Program Files (x86)\DevExpress\DXperience 12.2\Sources\DevExpress.Xpf.Scheduler\DevExpress.Xpf.Scheduler\Themes folder) to see how this is implemented. You can override them as shown in this example. The result should be as follows:</p><p></p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-remove-highlighting-of-the-current-day-header-and-alternate-cell-color-e4747/12.2.10+/media/e514375e-a8bd-4c5c-992f-4456f2cb0097.png"></p><p></p><p><strong>See Also:</strong></p><p><a href="https://www.devexpress.com/Support/Center/p/E3450">How to customize the SchedulerControl presentation differently for different themes</a></p><p><a href="https://www.devexpress.com/Support/Center/p/E4012">How to customize the SchedulerControl presentation in the same manner for different themes</a></p>

<br/>


