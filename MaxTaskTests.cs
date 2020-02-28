public class MaxTaskTests {
  public void Max_XEqualsY_ReturnX() {
    var task = new MaxTask();
    var result = task.Max(1, 1);
    Assert.AreEqual(1, result);
  }

  public void Max_XGreaterThanY_ReturnX() {
    var task = new MaxTask();
    var result = task.Max(2, 1);
    Assert.AreEqual(2, result);
  }

  public void Max_XLessThanY_ReturnY() {
    var task = new MaxTask();
    var result = task.Max(1, 2);
    Assert.AreEqual(2, result);
  }
}