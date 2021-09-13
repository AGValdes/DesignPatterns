using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Classes
{
  /// <summary>
  /// Represents an item being ordered from this restaurant.
  /// </summary>
  public class MenuItem
  {
    public string Name { get; set; }
    public int Qty { get; set; }
    public double Price { get; set; }

    public MenuItem(string name, int amount, double price)
    {
      Name = name;
      Qty = amount;
      Price = price;
    }

    public void Display()
    {
      Console.WriteLine("\nName: " + Name);
      Console.WriteLine("Amount: " + Qty.ToString());
      Console.WriteLine("Price: $" + Price.ToString());
    }
  }
}
