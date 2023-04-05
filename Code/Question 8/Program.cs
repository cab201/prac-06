namespace Question_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(4);
            TestNumber tester = new TestNumber(number);
            tester.Test();
        }
    }
}