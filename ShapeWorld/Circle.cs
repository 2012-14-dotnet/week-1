using System;

namespace ShapeWorld
{
  class Circle : Shape
  {
    internal double Radius;

    internal override double Surface()
    {
      return Math.PI * Math.Pow(Radius, 2);
    }
  }
}
