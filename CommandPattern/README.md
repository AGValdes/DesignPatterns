# The Command Design Pattern
 The Command design pattern is a *behavioral* design pattern wherein an object is used to to *encapsulate* all the information needed to carry out a certain request, so that it may be processed differently by different *recievers*.

 ![Command Pattern ERD](https://github.com/AGValdes/DesignPatterns/blob/master/CommandPattern/img/CommandERD.png)
 
 - The **Command**, in our case the *OrderCommand* abstract class, declares an interface for executing an operation. 
      ``` 
         public abstract class OrderCommand
         {
            public abstract void Execute(List<MenuItem> order, MenuItem newItem);
         }
      ```
