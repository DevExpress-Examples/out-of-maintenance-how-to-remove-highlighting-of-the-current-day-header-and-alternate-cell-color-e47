using System.Windows;
using System.Windows.Media;
using DevExpress.Xpf.Scheduler.Drawing;
using DevExpress.Xpf.Scheduler.Internal;

namespace SchedulerRemoveTodayHighlightingWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public class CustomDayViewCellBackgroundBrushSelector : ICellBrushSelector, ISchedulerDefaultCellBrushSelector {
        public Brush SelectBrush(VisualResourceCellBaseContent content) {
            VisualWorkTimeCellBaseContent workTimeCell = content as VisualWorkTimeCellBaseContent;
            
            if (workTimeCell == null)
                return null;
            if (workTimeCell.Brushes == null)
                return null;

            return workTimeCell.Brushes.CellLight;
        }
    }

    public class CustomMonthWeekViewCellBackgroundBrushSelector : ICellBrushSelector, ISchedulerDefaultCellBrushSelector {
        public Brush SelectBrush(VisualResourceCellBaseContent content) {
            VisualDateCellContent dateCell = content as VisualDateCellContent;
            
            if (dateCell == null)
                return null;
            if (dateCell.Brushes == null)
                return null;

            return dateCell.Brushes.CellLight;
        }
    }

    public class CustomTimelineViewCellBackgroundBrushSelector : ICellBrushSelector, ISchedulerDefaultCellBrushSelector {
        public Brush SelectBrush(VisualResourceCellBaseContent content) {
            VisualSingleTimelineCellContent cell = content as VisualSingleTimelineCellContent;
            if (cell == null)
                return null;
            if (cell.Brushes == null)
                return null;

            return cell.Brushes.CellLight;
        }
    }
}