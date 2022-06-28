<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128657400/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4747)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->
# How to remove highlighting of the current day header and alternate cell color


## Problem

By default my SchedulerControl is displayed as follows:

<img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-remove-highlighting-of-the-current-day-header-and-alternate-cell-color-e4747/12.2.10+/media/674ed945-18f2-4540-9432-77980e02da12.png">

Note that the current day header and worktime cell area are highlighted. I want to disable this highlighting for all views. 

## Solution

These elements are rendered according to the alternate styles and background brush selectors accordingly. You can examine the default themes (see the C:\Program Files (x86)\DevExpress 21.1\Components\Sources\DevExpress.Xpf.Scheduler\DevExpress.Xpf.Scheduler\Themes folder) to see how this is implemented. You can override them as shown in this example. The result should be as follows:

<img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-remove-highlighting-of-the-current-day-header-and-alternate-cell-color-e4747/12.2.10+/media/e514375e-a8bd-4c5c-992f-4456f2cb0097.png">

## See Also

* <a href="https://www.devexpress.com/Support/Center/p/E3450">How to customize the SchedulerControl presentation differently for different themes</a>
* <a href="https://www.devexpress.com/Support/Center/p/E4012">How to customize the SchedulerControl presentation in the same manner for different themes</a>


