using System;

namespace Command_Pattern
{
    class Program
    {
        public static bool isExitFlag = false;
        static void Main(string[] args)
        {
            CommandParser parser = new CommandParser();
            while (!Program.isExitFlag)
            {
                var command = Console.ReadLine();
                IResult result = parser.ParseCommand(command);
                result.WriteResultToLine();
            }
        }
    }
}
