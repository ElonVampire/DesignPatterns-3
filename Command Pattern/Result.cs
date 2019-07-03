using System;

namespace Command_Pattern
{
    internal class Result : IResult
    {
        public string _myResultText { get; set; }

        public IResult WriteResultToLine()
        {
            Console.WriteLine(_myResultText);
            return this;
        }
    }
}