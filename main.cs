using System;
using System.Reflection;

class MainClass {
  public static void Main (string[] args) {
    var maxTaskTests = new MaxTaskTests();
    Assert.DoesNotThrow(maxTaskTests.Max_XEqualsY_ReturnX);
    Assert.DoesNotThrow(maxTaskTests.Max_XGreaterThanY_ReturnX);
    Assert.DoesNotThrow(maxTaskTests.Max_XLessThanY_ReturnY);

    var minTaskTests = new MinTaskTests();
    Assert.DoesNotThrow(minTaskTests.Min_XEqualsY_ReturnX);
    Assert.DoesNotThrow(minTaskTests.Min_XGreaterThanY_ReturnY);
    Assert.DoesNotThrow(minTaskTests.Min_XLessThanY_ReturnX);
  }
}


public static class Assert {
  public static void AreEqual(int expected, int actual) {
    if (expected != actual) {
      throw new Exception($"Actual and expected values are not equal. Expected value: {expected}. Actual value: {actual}.");
    }
  }

  public static void DoesNotThrow(Action action) {
    try {
      action();
    }
    catch (Exception e) {
      var methodInfo = (action as Delegate).GetMethodInfo();
      Console.WriteLine($"Test {methodInfo.Name} failed: {e.Message}");
    }
  }
}