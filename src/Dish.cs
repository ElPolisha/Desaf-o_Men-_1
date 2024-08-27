namespace Ucu.Poo.Restaurant;

/// <summary>
/// Represent un plato individual en el menú del restaurant.
/// </summary>
public class Dish
{
    public string Name { get; private set; }
    public decimal Price { get; private set ; }
    public bool IsVegetarian { get; private set; }

    public Dish(string name, decimal price, bool isVegetarian)
    {
        Name = name;
        Price = price;
        IsVegetarian = isVegetarian;
    }

}