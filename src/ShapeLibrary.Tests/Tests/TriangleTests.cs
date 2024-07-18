namespace ShapeLibrary.Tests.Tests;

public class TriangleTests
{
    [Test]
    public void TriangleAreaTest()
    {
        // для хорошей практики лучше не использовать магические значения для тестов, 
        // но в рамках задания можно опустить этот пункт
        var triangle = new Triangle(3, 4, 5);

        double expectedArea = 6;

        Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedArea).Within(0.0001));
    }

    [Test]
    public void TriangleIsRightTest()
    {
        // для хорошей практики лучше не использовать магические значения для тестов, 
        // но в рамках задания можно опустить этот пункт
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightTriangle());
    }

    [Test]
    public void InvalidTriangleTest()
    {
        // для хорошей практики лучше не использовать магические значения для тестов, 
        // но в рамках задания можно опустить этот пункт
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }
}