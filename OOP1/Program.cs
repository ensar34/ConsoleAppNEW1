namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.ıd = 1;
            product1.CategoryId = 2;
            product1.ProductName = "MASA";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            product product2 = new product { ıd = 2, CategoryId = 5,
                UnitsInStock = 5, ProductName = "kalem", UnitPrice = 35 };

            ProdcutManager prodcutManager = new ProdcutManager();
            prodcutManager.Add(product1);
            Console.WriteLine(product1.ProductName);

           

        }
    }
}
