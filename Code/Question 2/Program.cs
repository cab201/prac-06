namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoccerPlayer player1 =
                new SoccerPlayer("Messi",
                10, 99, 151);
            player1.Display();

            SoccerPlayer player2 =
                new SoccerPlayer("Tim");
            player2.Display();
        }
    }
}