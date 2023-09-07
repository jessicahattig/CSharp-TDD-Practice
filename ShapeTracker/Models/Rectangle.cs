using System.Collections.Generic;

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

    // public string CheckType()
    // {
    //   if (Side1 == Side2)
    //   {
    //     return "it's a square, which is a special rectangle.";
    //   }
    //   else
    //   {
    //     return "it's a rectangle.";
    //   }
    // }
    public string CheckType()
    {
      if ((Side1 > Side2) || (Side1 < Side2))
      {
        return "it's a rectangle.";
      }
      else if ((Side1 == Side2) && (Side2 == Side1))
      {
        return "it's a square, which is a special rectangle.";
      } 
      else 
      {
        return "it's not a rectangle.";
      }
    }

    public static List<Rectangle> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
