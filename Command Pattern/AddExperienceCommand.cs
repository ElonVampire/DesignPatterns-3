namespace Command_Pattern
{
    internal class AddExperienceCommand : ICommand, IChainable
    {
        public ICommand _nextLink { get; set; }
        public string CommandString { get; set; } = "add experience";

        public IResult Execute(Character aChar, string aCommand)
        {
            if(aCommand != CommandString)
            {
                return _nextLink.Execute(aChar, aCommand);
            }
            else
            {
                aChar.exerience += 50;
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
                _myResultText = "50 Experience was added"
            };
        }
    }
}