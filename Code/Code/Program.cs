namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WhoLivesHere person = 
                new WhoLivesHere();
            person.person = "John";
            person.city = "Brisbane";
            person.SayHello();

            WhoLivesHere person2 = 
                new WhoLivesHere();
            person2.person = "Mary";
            person2.city = "Melbourne";
            person2.SayHello();
        }
    }
}