namespace ShapeWorld
{
  class Shape
  {
    internal virtual double Surface()
    {
      return 0;
    }

    protected virtual double Volume()
    {
      return 0;
    }
  }
}
