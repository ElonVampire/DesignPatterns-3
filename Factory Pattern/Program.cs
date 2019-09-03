using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuit = false;
            while (!isQuit)
            {
                var command = Console.ReadLine();
                if (command == "quit")
                    isQuit = true;
                else
                    isQuit = false;

                MapTileFactory factory = new MapTileFactory();
                IWorldTile tile = factory.CreateInstance(command);

                tile.SurveyArea();
            }
        }
    }
}
