using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class SoccerPlayer
    {
        public string name;
        public int jerseyNumber;
        public int goalsScored;
        public int assists;

        // Constructor: A method with the same name as the class
        public SoccerPlayer(string name, 
            int jerseyNumber, 
            int goalsScored, int assists)
        {
            this.name = name;
            this.jerseyNumber = jerseyNumber;
            this.goalsScored = goalsScored;
            this.assists = assists;
        }

        public SoccerPlayer(string name)
        {
            this.name = name;
            this.jerseyNumber = 1;
            this.goalsScored = 0;
            this.assists = 0;
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}" +
                " Number: {1}" +
                " Goals: {2}" +
                " Assists: {3}",
                name, jerseyNumber,
                goalsScored, assists);
        }
    }
}
