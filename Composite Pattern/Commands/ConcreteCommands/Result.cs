using System;

namespace Composite_Pattern
{
    internal class Result : IResult
    {
        private string _myMessage;

        public Result(string message)
        {
            _myMessage = message;
        }

        public Result()
        {
            _myMessage = "";
        }

        public void EvaulateToCommandLine()
        {
            Console.WriteLine(_myMessage);
        }
    }
}