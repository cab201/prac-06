namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoccerPlayer player1 = 
                new SoccerPlayer(
                    goalsScored: 99,
                    name: "Messi",
                    assists: 151,
                    jerseyNumber: 10
                    );
            player1.Display();

            SoccerPlayer player2 = 
                new SoccerPlayer("Tim");
            player2.Display();

            SoccerPlayer player3 =
                new SoccerPlayer();
            player3.Display();
        }
    }
}