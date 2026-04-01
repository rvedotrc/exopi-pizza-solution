using PizzaPlace.Models;

namespace PizzaPlace.Services;

public interface IStockService
{
    Task<bool> HasSufficientStock(PizzaOrder order, ComparableList<PizzaRecipeDto> recipeDtos);

    Task<ComparableList<StockDto>> GetStock(PizzaOrder order, ComparableList<PizzaRecipeDto> recipeDtos);
}
