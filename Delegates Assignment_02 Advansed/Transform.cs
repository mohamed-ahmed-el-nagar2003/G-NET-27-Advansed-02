using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment_02_Advansed
{
    internal class Transform 
    {
        public static List<string> transform(List<Product> products , Func<Product,string> func) 
        {
            List<string> result = new List<string>();
            foreach (Product product in products) 
            {
               result.Add(func(product));
            }
            return result;
        }
    }
}
