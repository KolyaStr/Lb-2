using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2._4
{
    public class Point
    {
        public int X { get; }

        public int Y { get; }

        public string Name { get; }
        public Point(int integer1, int integer2, string string1 = "")
        {

            X = integer1;
            Y = integer2;
            Name = string1;

        }
    }
}
