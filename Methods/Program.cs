using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };

            //type-safe -- tip güvenliği

            foreach (Product product in products)
            {
                Console.WriteLine("Ürün Adı: "+product.Name);
                Console.WriteLine("Fiyatı: "+product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("*********************");
            }

            Console.WriteLine("---------------Methods-----------------");
            //instance -- Class örneği oluşturmak
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            //Aşağıdaki yanlış kullanım örneği
            sepetManager.Add2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Add2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12, 8);

        }
    }
}



