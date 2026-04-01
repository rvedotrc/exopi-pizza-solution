using PizzaPlace.Services;

namespace PizzaPlace.Test.Services;

[TestClass]
public class MenuServiceTests
{
    [TestMethod]
    [DataRow(10, 0, 0)]
    [DataRow(10, 59, 59)]
    [DataRow(14, 0, 0)]
    [DataRow(22, 0, 0)]
    public void TestNotLunch(int hour, int minute, int second)
    {
        MenuService menuService = new();
        Menu menu = menuService.GetMenu(new(2000, 12, 31, hour, minute, second, TimeSpan.Zero));
        Assert.AreEqual(menu.Title, "Not Lunch");
        Assert.AreEqual(menu.Items.Count, 12);
        Assert.IsTrue(menu.Items.All(t => t.Price == 2));
    }

    [TestMethod]
    [DataRow(11, 0, 0)]
    [DataRow(13, 59, 59)]
    public void TestLunch(int hour, int minute, int second)
    {
        MenuService menuService = new();
        Menu menu = menuService.GetMenu(new(2000, 12, 31, hour, minute, second, TimeSpan.Zero));
        Assert.AreEqual(menu.Title, "Lunch");
        Assert.AreEqual(menu.Items.Count, 12);
        Assert.IsTrue(menu.Items.All(t => t.Price == 1));
    }
}
