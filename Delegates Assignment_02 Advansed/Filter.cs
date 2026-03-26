using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment_02_Advansed
{
    internal class Filter
    {
        public static List<Product> FilterStock(List<Product> products, Predicate<Product> pre)
        {
            List<Product> result = new List<Product>();
            foreach (var item in products)
            {
                if (true)
                {
                    result.Add(item);
                }

            }
            return result;
        }
    }
}
