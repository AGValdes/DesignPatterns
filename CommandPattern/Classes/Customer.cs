using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Classes
{
  /// <summary>
  /// The Invoker class
  /// </summary>
  public class Customer
  {
    private OrderCommand _orderCommand;
    private MenuItem _menuItem;
    private FastFoodOrder _order;

    public Customer()
    {
      _order = new FastFoodOrder();
    }

    public void SetCommand(int commandOption)
    {
      _orderCommand = new CommandFactory().GetCommand(commandOption);
    }

    public void SetMenuItem(MenuItem item)
    {
      _menuItem = item;
    }

    public void ExecuteCommand()
    {
      _order.ExecuteCommand(_orderCommand, _menuItem);
    }

    public void ShowCurrentOrder()
    {
      _order.ShowCurrentItems();
    }
  }

  public class CommandFactory
  {
    //Factory method
    public OrderCommand GetCommand(int commandOption)
    {
      switch (commandOption)
      {
        case 1:
          return new AddCommand();
        case 2:
          return new ModifyCommand();
        case 3:
          return new RemoveCommand();
        default:
          return new AddCommand();
      }
    }
  }
}
