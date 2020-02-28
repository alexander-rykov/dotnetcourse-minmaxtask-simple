public class MinTaskTests {
  public void Min_XEqualsY_ReturnX() {
    var task = new MinTask();
    var result = task.Min(1, 1);
    Assert.AreEqual(1, result);
  }

  public void Min_XGreaterThanY_ReturnY() {
    var task = new MinTask();
    var result = task.Min(2, 1);
    Assert.AreEqual(1, result);
  }

  public void Min_XLessThanY_ReturnX() {
    var task = new MinTask();
    var result = task.Min(1, 2);
    Assert.AreEqual(1, result);
  }
}