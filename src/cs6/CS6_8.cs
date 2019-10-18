using System;
using System.Collections.Generic;
//using System.Windows.Media.Media3D; // Linuxでは使えない……

namespace cs6
{
    class CS6_8
    {
        public void Run()
        {
            var messages = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };
            Console.WriteLine(messages[302]);
            /*
            Path8 p = new Path8();
            p.Add(new Point3D(1,2,3));
            p.Add(4.4, 5.5, 6.6);
            Console.WriteLine(p.ToString());
            */
        }
    }

    /*
    public class Path8 : IEnumerable<Point3D>
    {
        private List<Point3D> points = new List<Point3D>();
        public IEnumerator<Point3D> GetEnumerator() => points.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => points.GetEnumerator();

        public void Add(Point3D pt) => points.Add(pt);
    }

    public static class Extensions
    {
        public static void Add(this Path8 path, double x, double y, double z) => path.Add(new Point3D(x, y, z));
    }
    */
}
