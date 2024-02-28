using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double teotichuan = (rentacleArea(1500,2500))+(0.5*circleArea(375))+(triangleArea(500,750));
      double price = Math.Floor(teotichuan * 180);
      Console.WriteLine($"price: {price}");
    }
    //methods
    //areas calculator
    public static double rentacleArea(double length, double width) {
      return (length*width); //rentacle area = length * width
    }
    public static double circleArea(double radius) {
      return (Math.PI * Math.Pow(radius,2)); //circle area = pi * radius^2
    }
    public static double triangleArea(double height, double bottom) {
      return (0.5*bottom*height); //triangle area = 0.5 * bottom * height
    }

  }
}
