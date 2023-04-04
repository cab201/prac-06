namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhoLivesHere person = 
                new WhoLivesHere();
            person.name = "John";
            person.city = "Brisbane";
            person.Display();

            WhoLivesHere person2 = 
                new WhoLivesHere();
            person2.name = "Mary";
            person2.city = "Perth";
            person2.Display();
        }
    }
}