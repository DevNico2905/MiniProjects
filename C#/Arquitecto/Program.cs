namespace arquitecto;

class Program
{
    public static double Rectangle(double length, double width)
    {
      return length * width;
    }
    public static double Circle(double radius)
    {
      return Math.PI * Math.Pow(radius,2);
    }
    public static double Triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
    static void Main(string[] args)
    {
        double rectangleArea = Rectangle(1500, 2500);
        double midCircleArea = Circle(375)/2;
        double triangleArea = Triangle(750,500);
        double totalArea = rectangleArea + midCircleArea + triangleArea;
        Console.WriteLine($"The total area is: {totalArea}");
        double totalCost = totalArea * 180;
        Console.WriteLine($"My plan costs: {Math.Round(totalCost,2)} pesos");
        Console.ReadKey();
    }
}
