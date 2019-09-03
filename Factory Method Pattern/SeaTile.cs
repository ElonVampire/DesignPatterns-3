using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class SeaTile : IWorldTile
    {
        public void SurveyArea()
        {
            Console.WriteLine("You see before you a vast open sea with the sun glistening on her waves.");
        }
    }
}
