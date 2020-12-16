namespace ShapeWorld
{
  class Rectangle : Shape
  {
    internal double Length;
    internal double Width;

    internal override double Surface()
    {
      return Length * Width;
    }
  }
}
