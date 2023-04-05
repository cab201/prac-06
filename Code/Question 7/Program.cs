namespace Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Dan Tran", "n123456789");
            student.Display();
            Console.WriteLine("Is student valid? {0}", student.IsValid);

            Student student2 = new Student("John", "n12345678");
            student2.Display();
            Console.WriteLine("Is student valid? {0}", student2.IsValid);
        }
    }
}