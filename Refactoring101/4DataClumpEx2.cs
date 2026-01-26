using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101.DataClump2;

// 4.2
public class DataClump2
{
    public (double, double) AddPoint(double x1, double y1, double x2, double y2)
    {
        return ((x1 + y1), (x2+y2));
    }
}
