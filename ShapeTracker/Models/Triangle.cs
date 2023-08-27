using System.Collections.Generic;

namespace ShapeTracker.Models
{
  public class Triangle
  {
    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }

    private static List<Triangle> _instances = new List<Triangle> {};

    public Triangle(int length1, int length2, int length3)
    {
      Side1 = length1;
      Side2 = length2;
      Side3 = length3;
      _instances.Add(this); 
    }

    public string CheckType()
    {
      if ((Side1 > (Side2 + Side3)) || (Side2 > (Side1 + Side3)) || (Side3 > (Side1 + Side2)))
      {
        return "not a triangle";
      } 
      else if ((Side1 != Side2) && ((Side1 != Side3)) && ((Side2 != Side3))) 
      {
        return "scalene triangle";
      }  
      else if ((Side1 == Side2) && (Side1 == Side3)) 
      {
        return "equilateral triangle";
      } 
      else 
      {
        return "isosceles triangle";
      }
    }

    public static List<Triangle> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}