using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Classes
{
  /// <summary>
  /// The Receiver
  /// </summary>
  public class FoodOrder
  {
    public List<MenuItem> currentItems { get; set; }
    public FoodOrder()
    {
      currentItems = new List<MenuItem>();
    }

    public void ExecuteCommand(OrderCommand command, MenuItem item)
    {
      command.Execute(this.currentItems, item);
    }

    public void ShowCurrentItems()
    {
      foreach (var item in currentItems)
      {
        item.Display();
      }
      Console.WriteLine("-----------------------");
    }
  }
}
