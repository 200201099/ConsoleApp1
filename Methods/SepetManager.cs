using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    { 
        //naming convention -- İsimlendirme Kuralı
        //syntax -- Yazım Şekilleri
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Name);
        }

        public void Add2(string productName, string explanation, double price, int stockQuantity)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + productName);
        }
    }
}
