Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Media
Imports DevExpress.Xpf.Scheduler.Drawing
Imports DevExpress.Xpf.Scheduler.Internal

Namespace SchedulerRemoveTodayHighlightingWpf
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class CustomDayViewCellBackgroundBrushSelector
		Implements ICellBrushSelector, ISchedulerDefaultCellBrushSelector
        Public Function SelectBrush(ByVal content As VisualResourceCellBaseContent) As Brush Implements ICellBrushSelector.SelectBrush
            Dim workTimeCell As VisualWorkTimeCellBaseContent = TryCast(content, VisualWorkTimeCellBaseContent)

            If workTimeCell Is Nothing Then
                Return Nothing
            End If
            If workTimeCell.Brushes Is Nothing Then
                Return Nothing
            End If

            Return workTimeCell.Brushes.CellLight
        End Function
	End Class

	Public Class CustomMonthWeekViewCellBackgroundBrushSelector
		Implements ICellBrushSelector, ISchedulerDefaultCellBrushSelector
        Public Function SelectBrush(ByVal content As VisualResourceCellBaseContent) As Brush Implements ICellBrushSelector.SelectBrush
            Dim dateCell As VisualDateCellContent = TryCast(content, VisualDateCellContent)

            If dateCell Is Nothing Then
                Return Nothing
            End If
            If dateCell.Brushes Is Nothing Then
                Return Nothing
            End If

            Return dateCell.Brushes.CellLight
        End Function
	End Class

	Public Class CustomTimelineViewCellBackgroundBrushSelector
		Implements ICellBrushSelector, ISchedulerDefaultCellBrushSelector
        Public Function SelectBrush(ByVal content As VisualResourceCellBaseContent) As Brush Implements ICellBrushSelector.SelectBrush
            Dim cell As VisualSingleTimelineCellContent = TryCast(content, VisualSingleTimelineCellContent)
            If cell Is Nothing Then
                Return Nothing
            End If
            If cell.Brushes Is Nothing Then
                Return Nothing
            End If

            Return cell.Brushes.CellLight
        End Function
	End Class
End Namespace