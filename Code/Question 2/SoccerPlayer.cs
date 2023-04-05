using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class SoccerPlayer
    {
        private string name;
        private int jerseyNumber;
        private int goalsScored;
        private int assists;

        public SoccerPlayer() :
            this("No name", -1, -1, -1)
        {

        }

        // Constructor to initialise the fields
        public SoccerPlayer(string name, 
            int jerseyNumber, 
            int goalsScored, 
            int assists)
        {
            this.name = name;
            this.jerseyNumber = jerseyNumber;
            this.goalsScored = goalsScored;
            this.assists = assists;
        }

        public SoccerPlayer(string name)
        {
            this.name = name;
            this.jerseyNumber = 99;
            this.goalsScored = 0;
            this.assists = 0;
        }



        public void Display()
        {
            Console.WriteLine("{0} with number {1} has scored" +
                " {2} goals and has {3} assists",
                name, jerseyNumber,
                goalsScored, assists);
        }
    }
}
