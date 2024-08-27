using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    
    private ArrayList order = new ArrayList();
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
    public int Number { get; set; }
    public bool IsOccupied { get; set; }
    public void Occupy()
    {
        if (IsOccupied)
        {
            Console.Write("\n La mesa esta ocupada. ");
        }
        else
        {
            IsOccupied = true;
            Console.Write("\n La mesa esta libre. ");
        }
    }
    public void Free()
    {
        IsOccupied = false;
        Console.Write("\n La mesa esta libre. ");
    }

    public void AddToOrder(object dish)
    {
        order.Add(dish);
        Console.WriteLine("\n Se agrego el plato. ");
    }
}