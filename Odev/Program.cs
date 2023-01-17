internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.ProductName = "Laptop";
        product1.UnitPrice = 10000;

        Product product2 = new Product();
        product2.Id = 2;
        product2.ProductName = "Tablet";
        product2.UnitPrice = 2000;

        Product[] products= new Product[] { product1, product2 };

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine(products[i].ProductName +" :" + products[i].UnitPrice);
        }
        Console.WriteLine("---for bitti---");
        
        foreach (var product in products)
        {
            Console.WriteLine(product.ProductName +": "+ product.UnitPrice  );
        }
        Console.WriteLine("---foreach bitti---");

        int j = 0;
        while (j<products.Length)
        {
            Console.WriteLine(products[j].ProductName +": "+ products[j].UnitPrice);
            j++;
        }
    }
    class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int UnitPrice { get; set; }

    }
}