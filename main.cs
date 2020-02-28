using System;

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