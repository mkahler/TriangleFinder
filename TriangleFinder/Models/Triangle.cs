using System.Collections.Generic;
using System.Drawing;

namespace TriangleFinder.Models
{
    public class Triangle
    {
        public readonly string Label;
        public readonly List<Point> Vertices;

        public Triangle(Point v1, Point v2, Point v3, string label)
        {
            Label = label;

            Vertices = new List<Point>() { v1, v2, v3 };
        }
    }
}
