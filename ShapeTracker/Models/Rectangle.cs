using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ShapeTracker.Models
{
  public class Rectangle
  {
    public int Side1 { get; set; }
    public int Side2 { get; set; }

    private static List<Rectangle> _instances = new List<Rectangle> {};

    public Rectangle (int length1, int length2)
    {
      Side1 = length1;
      Side2 = length2;
      _instances.Add(this);
    }

    public static List<Rectangle> GetAll()
    {
      return _instances;
    }
    }
  }
