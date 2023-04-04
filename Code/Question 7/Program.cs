namespace Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number four = new Number(4);
            NumberTester tester = new NumberTester(four);
            tester.Test();
        }
    }
}