using System;
using System.Reflection;

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