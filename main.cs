using System;

class Program {
  public static void Main (string[] args) {
  
  /* Declaring Variable */
    string item = "apple";
    int quantity = 10;
    double price = 0.75;
    

  
  
  
  
  /* Output Statements */
    Console.WriteLine("Enter the name of item");
    Console.WriteLine(item);
    Console.WriteLine("Enter the quantity");
    quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the price");
    price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Total price of apple=" + quantity * price);

    




    
  }
}