namespace ShapeLibrary.Tests.Tests;

public class AreaCalculatorTests : BaseTest
{
    [Test]
    public void ShapeAreaCalculatorTest()
    {
        // для хорошей практики лучше не использовать магические значения для тестов, 
        // но в рамках задания можно опустить этот пункт
        IShape circle = new Circle(5);
        IShape triangle = new Triangle(3, 4, 5);

        Assert.AreEqual(Math.PI * 25, ShapeAreaCalculator.CalculateArea(circle), 0.0001);
        Assert.AreEqual(6, ShapeAreaCalculator.CalculateArea(triangle), 0.0001);
    }
}