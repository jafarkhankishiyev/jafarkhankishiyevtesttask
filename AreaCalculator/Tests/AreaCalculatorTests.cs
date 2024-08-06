using AreaCalculator.Shapes.Concrete;
using NUnit.Framework;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class AreaCalculatorTests
    {
        [Test]
        public void CalculateCircleArea()
        {
            var circle = new Circle(1.3);
            double expectedArea = 5.30929;

            if (Math.Round(AreaCalculator.CalculateArea(circle), 5) == expectedArea)
                Assert.Pass();
            else 
                Assert.Fail();
        }

        [Test]
        public void CalculateTriangleArea()
        {
            var triangle = new Triangle(5, 6, 7);
            double expectedArea = 14.697;

            if (Math.Round(AreaCalculator.CalculateArea(triangle), 3) == expectedArea)
                Assert.Pass();
            else
                Assert.Fail();
        }
    }
}
