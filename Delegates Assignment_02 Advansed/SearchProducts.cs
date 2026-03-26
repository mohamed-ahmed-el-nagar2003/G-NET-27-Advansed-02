using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment_02_Advansed
{
    internal class SearchProducts
    {

        public static List<Product> Search(List<Product> catalog, Func<Product, bool> condition)
        {
            List<Product> result =  new List<Product>();
            foreach (Product product in catalog)
            {
                if (condition(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }



    }
}

