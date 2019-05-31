using System;
using System.Dynamic;
using PriceCalculator;

namespace PriceCalculatorLogger
{
  class Program
  {
    static void Main(string[] args)
    {
      var product = new Product
      {
        Name = "The Little Prince",
        Price = new Money(20.25m),
        Upc = 12345
      };

      var discount = 50;
      var tax = new Tax(20);

      var calculator = new PriceCalculator.PriceCalculator();
      var result = calculator.Calculate(product, tax, discount);
      Console.WriteLine($"{result}");
      Console.ReadLine();
    }
  }
}
