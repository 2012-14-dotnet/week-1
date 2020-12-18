namespace ShapeWorld
{
  class Rectangle : Shape
  {
    const int lines = 4;
    const int corners = 4;

    internal double Length;
    internal double Width;

    internal override double Surface()
    {
      return Length * Width;
    }
  }
}
