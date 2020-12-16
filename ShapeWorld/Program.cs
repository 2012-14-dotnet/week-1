using System;

namespace ShapeWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string s = "shape";
      string sq = "square";
      // datatypes
      // char, string, int, float, double, decimal, boolean, uint, byte, sbyte, long, ulong

      PlayWithShape();
    }

    static void PlayWithShape()
    {
      Rectangle r = new Rectangle();

      r.Length = 5;
      r.Width = 4;

      Output(r.Surface().ToString());
    }

    static void Output(string data)
    {
      System.Console.WriteLine(data);
    }

    // static void Square()
    // {
    //   Rectangle();
    //   int lineLength = 4;

    //   Console.WriteLine($"this is a Square of length: {lineLength}");
    // }

    // static void Rectangle()
    // {
    //   Shape();
    //   int lines = 4;
    //   int corners = 4;
    //   int hLength = 4;
    //   int vLength = 4;

    //   Console.WriteLine($"this is Rectangle of h: {hLength} and v: {vLength}");
    // }

    // static void Shape()
    // {
    //   Surface();
    //   Volume();
    // }

    // static void Circle()
    // {
    //   Shape();
    // }

    // static void Dimension(double x, double y, Shape s)
    // {
    //   if (s is Square)
    //   {
    //     s.Surface();
    //   }

    //   if (s is Cube)
    //   {
    //     s.Volume();
    //   }
    // }
  }
}
