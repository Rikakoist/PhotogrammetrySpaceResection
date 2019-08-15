using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotogrammetrySpaceResection
{
    public class ResectionPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
    class AngleDMS
    {
        public double Degree;
        public double Minute;
        public double Second;
    }

    class AngleARC
    {
        public double ARC;
    }

    class AngleDEC
    {
        public double DEC;
    }
}
