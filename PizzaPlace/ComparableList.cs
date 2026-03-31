namespace PizzaPlace;

/// <summary>
/// Just a list with equals to match if all items match.
/// </summary>
/// <typeparam name="T"></typeparam>
public class ComparableList<T> : List<T>
{
    public override bool Equals(object? obj) =>
    obj is ComparableList<T> otherList &&
    Count == otherList.Count &&
    this.Zip(otherList).All(x => x.First?.Equals(x.Second) ?? x.Second is null);

    public override int GetHashCode() =>
        this.Aggregate(0, (hash, item) => HashCode.Combine(hash, item?.GetHashCode()));
}
