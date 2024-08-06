using AreaCalculator.Shapes.Abstract;

namespace AreaCalculator
{
    public static class AreaCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
