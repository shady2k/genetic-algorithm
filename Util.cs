using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ga
{
    public static class Util
    {
        private static Random rnd = new Random();
        public static double NextDouble(
            double minValue,
            double maxValue)
        {
            return rnd.NextDouble() * (maxValue - minValue) + minValue;
        }
        public static double NextDouble()
        {
            return rnd.NextDouble();
        }
        public static Int32 Next()
        {
            return rnd.Next();
        }
        public static Int32 Next(Int32 x)
        {
            return rnd.Next(x);
        }
        public static Int32 Next(Int32 x, Int32 y)
        {
            return rnd.Next(x, y);
        }
    }
}
