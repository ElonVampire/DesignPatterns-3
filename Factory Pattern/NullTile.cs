using System;

namespace Factory_Pattern
{
    public class NullTile : IWorldTile
    {
        public void SurveyArea()
        {
            Console.WriteLine("You stare into the void and it stares back.");
        }
    }
}