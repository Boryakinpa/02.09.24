namespace _02._09._24_Magazine_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Toy toy = new Toy();
            Meat meat = new Meat();
            Drinks drinks = new Drinks();
            for (int i = 0; i < 10; i++)
            {
                toy = new Toy(name: "toy " + (i+1), price: 10.00 + i, age: 10 + i);
                meat = new Meat(name: "meat " + (i+1), price: 10.00 + i, filletPercentage: 90 - i);
                drinks = new Drinks(name: "drink " + (i+1), price: 10.00 + i, alcoholism: 3 + i);
                list.Add(toy);
                list.Add(meat);
                list.Add(drinks);
            }

            list[0].GetInformation();
            Console.WriteLine("\n\n");

            Product product;
            for (int i = 0; i < list.Count; i++)
            {
                product = (Product)list[i];
                Console.WriteLine($"Product name: {product.Name}; \nProduct price: {Math.Round(product.Price, 2)}\n");
            }
        }
    }
}
