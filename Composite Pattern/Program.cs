using System;

namespace Composite_Pattern
{
    class Program
    {
        public static bool isExitFlag = false;
        static void Main(string[] args)
        {
            CommandParser parser = new CommandParser(new AdventurerCommandsMaker());
            while (!isExitFlag)
            {
                IResult result = parser.ParseCommand(Console.ReadLine());
                result.EvaulateToCommandLine();
            }
        }
    }
}
