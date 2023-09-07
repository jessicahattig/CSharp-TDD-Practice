using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
   public class RectangleTests : IDisposable
  {
    public void Dispose()
    {
      Rectangle.ClearAll();
    }
  

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

    [TestMethod]
    public void GetAll_ReturnsAllRectangleInstances_List()
    {
      //Arrange
      Rectangle rec1 = new Rectangle(4, 8);
      Rectangle rec2 = new Rectangle(9, 5);
      List<Rectangle> expected = new List<Rectangle> { rec1, rec2, };
      //Act
      List<Rectangle> actualResult = Rectangle.GetAll();

      Console.WriteLine("Expected:");
      foreach (var rect in expected)
      {
        Console.WriteLine($"Side1: {rect.Side1}, Side2: {rect.Side2}");
      }

      Console.WriteLine("Actual:");
      foreach (var rect in actualResult)
      {
        Console.WriteLine($"Side1: {rect.Side1}, Side2: {rect.Side2}");
      }
      //Assert
      CollectionAssert.AreEqual(expected, actualResult);
    }

    [TestMethod]
    public void ClearAll_DeletesAllRectanglesInList_Void()
    {
      //Arrange
      Rectangle rec1 = new Rectangle(2, 5);
      Rectangle rec2 = new Rectangle(6, 4);
      List<Rectangle> expected = new List<Rectangle> {};
      //Act 
      Rectangle.ClearAll();
      //Assert
      CollectionAssert.AreEqual(expected, Rectangle.GetAll());
    }

    [TestMethod]
    public void GetArea_CalculatesAreaofRectangle_Int()
    {
      //Arrange
      Rectangle rec1 = new Rectangle(2, 5);
      int expectedArea = rec1.Side1 * rec1.Side2;
      //Act
      int actualArea = rec1.GetArea();
      //Assert
      Assert.AreEqual(expectedArea, actualArea);
    }     
  }
}