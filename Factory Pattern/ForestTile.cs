using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class ForestTile : IWorldTile
    {
        public void SurveyArea()
        {
            Console.WriteLine("You stand at the foot of a great pine with an army of one million trees behind it.\nA sense of dread washes over you.");
        }
    }
}
