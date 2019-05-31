using PriceCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace PriceCalculatorTests
{
  public class PriceCalculatorTests
  {
    public Product product = new Product
    {
      Name = "The Little Pony",
      Price = new Money(20.25m),
      Upc = 12345
    };

    [Theory]
    [InlineData(10, 18.23)]
    [InlineData(21, 20.45)]
    public void CalculateInput_ReturnCorrectPrice(int taxInput, decimal expectedAmount)
    {
      var tax = new Tax(taxInput);
      var discount = 20;
      var priceCalculator = new PriceCalculator.PriceCalculator();
      var result = priceCalculator.Calculate(product, tax, discount);
      var expectedAmountDollarFormat = expectedAmount.ToString("C");
      Assert.Equal(expectedAmountDollarFormat, result);
    }
  }


}
