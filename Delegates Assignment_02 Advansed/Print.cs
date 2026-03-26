using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment_02_Advansed
{
    internal class Print
    {
      public static void PrintReport(List<Product> products , Action<Product> action)
        {
          
            foreach (Product product in products)
            {
                action(product);
            }
        }
    }
}
