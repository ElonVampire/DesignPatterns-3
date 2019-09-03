using System;
using System.Reflection;

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

                IMapTileFactory factory = LoadFactory();
                IWorldTile tile = factory.CreateWorldTile();

                tile.SurveyArea();
            }
        }

        private static IMapTileFactory LoadFactory()
        {
            string factoryName = Factory_Method_Pattern.Properties.Settings1.Default.WorldTileFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IMapTileFactory;
        }
    }
}
