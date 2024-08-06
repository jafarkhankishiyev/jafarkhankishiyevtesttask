using AreaCalculator.Shapes.Abstract;

namespace AreaCalculator.Shapes.Concrete
{
    public class Triangle : IShape
    {
        // Edge values are equal to length of each edge of the triangle
        public double[] Edges { get; set; }

        public Triangle(double edge1, double edge2, double edge3)
        {
            Edges = new double[3];

            Edges[0] = edge1;
            Edges[1] = edge2;
            Edges[2] = edge3;
        }

        // Calculating area using Heron's formula
        public double CalculateArea()
        {
            var semiPerimeter = (Edges[0] + Edges[1] + Edges[2]) / 2;

            var area = Math.Sqrt((semiPerimeter * (semiPerimeter - Edges[0]) * (semiPerimeter - Edges[1]) * (semiPerimeter - Edges[2])));

            return area;
        }

        public bool IsRectangular()
        {
            // Moving the longest edge to the end to know where the hypothenuse is supposed to be
            Array.Sort(Edges);

            // Pythagorean formula
            return Edges[0] * Edges[0] + Edges[1] * Edges[1] == Edges[2] * Edges[2];
        }
    }
}
