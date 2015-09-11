using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CollisionTest.Controls
{
    /// <summary>
    /// Courtesy of http://stackoverflow.com/questions/6292639/click-drag-and-scroll-canvas-view
    /// </summary>
    public class ScrollableCanvas : Canvas
    {

        static ScrollableCanvas()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ScrollableCanvas), new FrameworkPropertyMetadata(typeof(ScrollableCanvas)));
        }

        protected override Size MeasureOverride(Size constraint)
        {
            Size toReport = new Size();

            foreach (UIElement element in InternalChildren)
            {
                //Get the left most and top most point.
                //No using Bottom or Right in case the controls actual bottom and right most points are less then the desired height/width
                var left = GetLeft(element);
                var top = GetTop(element);

                left = double.IsNaN(left) ? 0 : left;
                top = double.IsNaN(top) ? 0 : top;

                element.Measure(constraint);

                Size desiredSize = element.DesiredSize;

                if (!double.IsNaN(desiredSize.Width) && !double.IsNaN(desiredSize.Height))
                {
                    toReport.Width = toReport.Width > left + desiredSize.Width ? toReport.Width : left + desiredSize.Width;
                    toReport.Height = toReport.Height > top + desiredSize.Height ? toReport.Height : top + desiredSize.Height;
                }
            }

            //Make sure scroll includes the margins incase of a border or something
            toReport.Width += Margin.Right;
            toReport.Height += Margin.Bottom;

            return toReport;
        }
    }
}
