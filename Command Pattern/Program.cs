using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExitFlag = false;
            CommandParser parser = new CommandParser();
            while (!isExitFlag)
            {
                var command = Console.ReadLine();
                IResult result = parser.ParseCommand(command);
                result.WriteResultToLine();
                Console.WriteLine(command);
            }
        }
    }
}
