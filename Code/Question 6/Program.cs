namespace Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HousePlant plant = 
                new HousePlant("Philodendron", 29.99, false);

            Console.WriteLine("Name: {0}", plant.Name);
            Console.WriteLine("Price: {0}", plant.Price);

            plant.Price = 3.1415926535;
            Console.WriteLine("Discount Price: {0}", plant.Price);

            Console.WriteLine("Fed: {0}", plant.Fed);
            plant.Feed();
            Console.WriteLine("Fed: {0}", plant.Fed);
        }
    }
}