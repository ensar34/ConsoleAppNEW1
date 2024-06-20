using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProdcutManager
    {
      public void Add(product Product)
      {
            Console.WriteLine(Product.ProductName + " eklendi "  );

      }
      public void Update(product Product)
        {
            Console.WriteLine(Product.ProductName + " güncellendi"  );
        }

     
    }
    
}
