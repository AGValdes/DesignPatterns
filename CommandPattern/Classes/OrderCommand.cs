using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Classes
{
  /// <summary>
  /// The Command abstract class
  /// </summary>
  public abstract class OrderCommand
  {
    public abstract void Execute(List<MenuItem> order, MenuItem newItem);
  }

  /// <summary>
  /// A concrete command
  /// </summary>
  public class AddCommand : OrderCommand
  {
    public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
    {
      currentItems.Add(newItem);
    }
  }

  /// <summary>
  /// A concrete command
  /// </summary>
  public class RemoveCommand : OrderCommand
  {
    public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
    {
      currentItems.Remove(currentItems.Where(x => x.Name == newItem.Name).First());
    }
  }

  /// <summary>
  /// A concrete command
  /// </summary>
  public class ModifyCommand : OrderCommand
  {
    public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
    {
      var item = currentItems.Where(x => x.Name == newItem.Name).First();
      item.Price = newItem.Price;
      item.Qty = newItem.Qty;
    }
  }
}
