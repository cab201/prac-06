namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car honda = new Car("Honda", 10);
            honda.Display();

            Car mazda = new Car("Mazda");
            mazda.Display();
        }
    }
}