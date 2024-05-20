using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_7
{
    public class Point3D : Point2D<int>
    {
        public int Z {  get; set; }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public override string ToString()
        {
            return $"x= {X}, y= {Y}, z= {Z}";

        }
    }
}
