using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProductName = "Elma";
            double Price = 15;
            string Detail = "Amasya elmasi";

            string[] Meyveler = new string[] { };

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Id = 1;
            product1.Price = 12;
            product1.Detail = "Amasya elmasi";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Id = 2;
            product2.Price = 3;
            product2.Detail = "Diyarbakir karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine("Urun adi : " + product.Name);
            }

            Console.WriteLine("---Metotlar---");

            SepetManager sepetManager = new SepetManager();
            

            foreach (var product in products)
            {
                sepetManager.Add(product);
            }

            sepetManager.Add2(3, "Armut", 6.55, "Koy armudu");
        }
    }
}
