using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator
{
  public class PriceCalculator
  {
    public string Calculate(Product product, Tax tax, decimal discount)
    {
      var taxToAdd = product.Price.Value * (tax.Value / 100);
      var discountToDeduct = product.Price.Value * (discount / 100);
      var finalPrice = (product.Price.Value + taxToAdd - discountToDeduct).ToString("C");
      var priceWithTax = (product.Price.Value + taxToAdd).ToString("C");

      if (tax != null && discount != null)
      {
        return $"Name: {product.Name}" + "\n" +
               $"Original Price: {product.Price.Value.ToString("C")}" + "\n" +
               $"Tax Applied: {taxToAdd.ToString("C")}" + "\n" +
               $"Discount Applied: {discountToDeduct.ToString("C")}" + "\n" +
               $"Final price:{finalPrice}";
      }

      return priceWithTax;
    }
  }
}
