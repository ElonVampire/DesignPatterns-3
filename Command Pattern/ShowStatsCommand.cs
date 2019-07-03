namespace Command_Pattern
{
    internal class ShowStatsCommand : ICommand, IChainable
    {
        public ICommand _nextLink { get; set; }
        public string CommandString { get; set; } = "show";

        public IResult Execute(Character aChar, string aCommand)
        {
            if (aCommand != CommandString)
            {
                return _nextLink.Execute(aChar, aCommand);
            }
            else
            {
                return BuildResult(aChar);
            }
        }

        public IChainable SetNext(ICommand next)
        {
            _nextLink = next;
            return next;
        }

        protected IResult BuildResult(Character aChar)
        {
            return new Result
            {
                _myResultText = string.Format("This character currently has {0} money and {1} experience", aChar.money, aChar.exerience)
            };
        }
    }
}