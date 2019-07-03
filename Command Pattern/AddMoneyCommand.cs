namespace Command_Pattern
{
    internal class AddMoneyCommand : ICommand, IChainable
    {
        public ICommand _nextLink { get; set; }
        public string CommandString { get; set; } = "add money";

        public IResult Execute(Character aChar, string aCommand)
        {
            if (aCommand != CommandString)
            {
                return _nextLink.Execute(aChar, aCommand);
            }
            else
            {
                aChar.money += 50;
                return BuildResult();
            }
        }

        public IChainable SetNext(ICommand next)
        {
            _nextLink = next;
            return next;
        }

        protected IResult BuildResult()
        {
            return new Result
            {
                _myResultText = "50 money was added"
            };
        }
    }
}