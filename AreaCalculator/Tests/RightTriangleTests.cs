using AreaCalculator.Shapes.Concrete;
using NUnit.Framework;

namespace AreaCalculator.Tests
{
    public class RightTriangleTests
    {
        [Test]
        public void DetermineIfTriangleIsRight_ShouldReturnFalse()
        {
            var triangle = new Triangle(5, 7, 9);

            if (triangle.IsRectangular() == false)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void DetermineIfTriangleIsRight_ShouldReturnTrue()
        {
            var triangle = new Triangle(6, 8, 10);

            if (triangle.IsRectangular() == true)
                Assert.Pass();
            else
                Assert.Fail();

        }
    }
}
