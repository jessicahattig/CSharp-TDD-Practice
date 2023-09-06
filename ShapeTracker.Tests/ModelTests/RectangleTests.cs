using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Rectangle.ClearAll();
    // }
  

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(4, 6);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]

    public void GetSide1_ReturnsSide1_Int()
    {
      //Arrange
      int length1 = 4;
      Rectangle newRectangle = new Rectangle(length1, 6);
      //Act
      int result = newRectangle.Side1;
      //Assert
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(2, 8);
      int newLength1 = 2;
      // Act
      newRectangle.Side1 = newLength1;
      // Assert
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    
    {
      // Arrange
      int length2 = 3;
      Rectangle newRectangle = new Rectangle(2, length2);
      // Act
      int result = newRectangle.Side2;
      // Assert
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(3, 4);
      int newLength2 = 4;
      // Act
      newRectangle.Side2 = newLength2;
      // Assert
      Assert.AreEqual(newLength2, newRectangle.Side2);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenSquare_String()
    {
      // Arrange
      Rectangle squaRectangle = new Rectangle(4, 4);
      // Act
      string recType = squaRectangle.CheckType();
      // Assert
      Assert.AreEqual("it's a square, which is a special rectangle.", recType);
    }

        [TestMethod]
    public void CheckType_DeterminesWhenRectangle_String()
    {
      // Arrange
      Rectangle trueRectangle = new Rectangle(4, 6);
      // Act
      string recType = trueRectangle.CheckType();
      // Assert
      Assert.AreEqual("it's a rectangle.", recType);
    }

    // [TestMethod]
    // public void CheckType_DeterminesWhenScalene_String()
    // {
    //   // Arrange
    //   Triangle scaleneTri = new Triangle(3, 4, 5);
    //   // Act
    //   string triType = scaleneTri.CheckType();
    //   // Assert
    //   Assert.AreEqual("scalene triangle", triType);
    // }

    // [TestMethod]
    // public void CheckType_DeterminesWhenIsosceles_String()
    // {
    //   // Arrange
    //   Triangle isoscelesTri = new Triangle(5, 4, 4);
    //   // Act
    //   string triType = isoscelesTri.CheckType();
    //   // Assert
    //   Assert.AreEqual("isosceles triangle", triType);
    // }

    // [TestMethod]
    // public void CheckType_DeterminesWhenEquilateral_String()
    // {
    //   // Arrange
    //   Triangle equiTri = new Triangle(4, 4, 4);
    //   // Act
    //   string triType = equiTri.CheckType();
    //   // Assert
    //   Assert.AreEqual("equilateral triangle", triType);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsAllTriangleInstances_List()
    // {
    //   // Arrange
    //   Triangle tri1 = new Triangle(2, 2, 9);
    //   Triangle tri2 = new Triangle(21, 3, 9);
    //   Triangle tri3 = new Triangle(1, 3, 9);
    //   List<Triangle> expected = new List<Triangle> { tri1, tri2, tri3 };
    //   // Act
    //   List<Triangle> actualResult = Triangle.GetAll();
    //   // Assert
    //   CollectionAssert.AreEqual(expected, actualResult);
    // }

    // [TestMethod]
    // public void ClearAll_DeletesAllTriangleInList_Void()
    // {
    //   // Arrange
    //   Triangle tri1 = new Triangle(2, 2, 9);
    //   Triangle tri2 = new Triangle(21, 3, 9);
    //   Triangle tri3 = new Triangle(1, 3, 9);
    //   List<Triangle> expected = new List<Triangle> { };
    //   // Act
    //   Triangle.ClearAll();
    //   // Assert
    //   CollectionAssert.AreEqual(expected, Triangle.GetAll());
    // }
  }
}