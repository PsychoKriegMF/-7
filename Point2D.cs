﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_7
{
    public class Point2D<T>
    {
        public T X { get; set; }

        public T Y { get; set; }

        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
    }
}