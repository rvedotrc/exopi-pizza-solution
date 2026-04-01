namespace PizzaPlace.Services;

public class MenuService : IMenuService
{
    public Menu GetMenu(DateTimeOffset menuDate)
    {
        bool isLunch = menuDate.Hour >= 11 && menuDate.Hour < 14;

        MenuItem i = new("spam", Models.Types.PizzaRecipeType.OddPizza, isLunch ? 1 : 2);

        return new Menu(
            isLunch ? "Lunch" : "Not Lunch",
            [i, i, i, i, i, i, i, i, i, i, i, i,]
        );
    }
}
