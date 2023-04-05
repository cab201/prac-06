// 1.	Create a class called WhoLivesHere.
// The WhoLives class should contain 2 strings:
// a person and a city. Write a number of
// class initialisations (aka objects) to
// test that WhoLivesHere is working correctly. 
class WhoLivesHere
{
    public string person;
    public string city;

    public void SayHello()
    {
        Console.WriteLine("{0} lives in {1}",
            person, city);
    }
}