namespace Command_Pattern
{
    internal class EndOfChainItem : ICommand, IChainable
    {
        public string CommandString { get; set; } = null;
        public ICommand _nextLink { get; set; }

        public IResult Execute(Character aChar, string aaCommand)
        {
            if(aaCommand == "exit")
            {
                Program.isExitFlag = true;
                return BuildExitResult();
            }
            else
            {
                return BuildResult();
            }
        }

        public IChainable SetNext(ICommand next)
        {
            throw new System.NotImplementedException();
        }

        protected IResult BuildResult()
        {
            return new Result()
            {
                _myResultText = "There was no such command"
            };
        }

        protected IResult BuildExitResult()
        {
            return new Result()
            {
                _myResultText = "BYE!"
            };

        }
    }
}