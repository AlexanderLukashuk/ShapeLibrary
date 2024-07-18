namespace ShapeLibrary.Tests.Tests;

public class CircleTests : BaseTest
{
    [Test]
    public void CircleAreaTest()
    {
        // для хорошей практики лучше не использовать магические значения для тестов, 
        // но в рамках задания можно опустить этот пункт
        var circle = new Circle(5);

        double expectedArea = Math.PI * 25;

        Assert.AreEqual(expectedArea, circle.CalculateArea(), 0.0001);
    }
}