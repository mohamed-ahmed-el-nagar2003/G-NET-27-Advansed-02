namespace Delegates_Assignment_02_Advansed
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> catalog = new()
{
    new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
    new Product { Id=2,Name="Phone", Category="Electronics", Price=800, Stock=25 },
    new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
    new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
    new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
    new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
    new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
    new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
    new Product { Id=9,Name="Headphones", Category="Electronics", Price=150, Stock=60 }};
            #region task_01

            // Console.WriteLine("============================Electronics===============================");
            // Func<Product,bool> conditionOfElectronics = product => product.Category == "Electronics" ;
            //List<Product> ElectronicProducts = SearchProducts.Search(catalog, conditionOfElectronics);
            // foreach (Product product in ElectronicProducts)
            // {
            //     Console.WriteLine($"{product.Name}-{product.Price}({product.Stock})");
            // }

            // Console.WriteLine("============================cheaper than 50$===============================");

            // Func<Product, bool> cheaperthan = product => product.Price < 50;
            // List<Product> Cheaper = SearchProducts.Search(catalog, cheaperthan);
            // foreach (Product product in Cheaper)
            // {
            //     Console.WriteLine($"{product.Name}-{product.Price}({product.Stock})");
            // }

            // Console.WriteLine("============================in stock (Stock > 0) ===============================");


            //      Func<Product, bool> inStock = product => product.Stock > 0;
            // List<Product> InStock = SearchProducts.Search(catalog, inStock);
            // foreach (Product product in InStock)
            // {
            //     Console.WriteLine($"{product.Name}-{product.Price}({product.Stock})");
            // }

            // Console.WriteLine("============================ Clothing products under $100 ===============================");
            //        Func<Product, bool> Clothing = product => product.Category == "Clothing";
            // List<Product> Clothes = SearchProducts.Search(catalog, Clothing);
            // foreach (Product product in Clothes)
            // {
            //     Console.WriteLine($"{product.Name}-{product.Price}({product.Stock})");
            // }
            #endregion

            #region task_03
            #region 3.1  Print Reports 


            //Console.WriteLine("==========================Short Report==========================");
            //Action<Product> ShortReport = product => Console.WriteLine($"{product.Name} - {product.Price}$");
            //Print.PrintReport(catalog, ShortReport);

            //Console.WriteLine("==========================Details Report==========================");
            //Action<Product> DetailsReport = product => Console.WriteLine($"[{product.Category}] {product.Name} | Price: {product.Price}$ | Stock :{product.Stock}");
            //Print.PrintReport(catalog, DetailsReport);
            #endregion

            #region 3.2. Transform Products 
            //Console.WriteLine("=======================summary List========================");
            //Func<Product,string> sumList = product => $"{product.Name} ({product.Price})";
            //List<string> summaryList = Transform.transform(catalog, sumList);
            //foreach (var item in summaryList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("=======================Label List========================");

            //Func<Product, string> label = delegate (Product product) 
            //{
            //    string exp;
            //    if (product.Price > 100)
            //    {
            //        exp = "Expensive";
            //    }
            //    else
            //    {
            //        exp = "Affordable";
            //    }
            //    return $"{product.Name} : {exp}";
            //};
            //List<string> LabelList = Transform.transform(catalog, label);
            //foreach (var item in LabelList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion


        }


    }

}
