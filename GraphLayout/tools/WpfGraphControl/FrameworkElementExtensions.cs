using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Microsoft.Msagl.WpfGraphControl
{
    public static class FrameworkElementExtensions
    {
        public static Size MeasureDesiredSize(this FrameworkElement element)
        {
            element.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            return element.DesiredSize;
        }
    }
}
