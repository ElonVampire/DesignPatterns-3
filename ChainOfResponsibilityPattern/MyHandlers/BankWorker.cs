namespace ChainOfResponsibilityPattern.MyHandlers
{
    internal class BankWorker
    {
        public int loanLimit { get; set; }
        public bool hasInterestOverride { get; set; } = false;
        public string name { get; set; }

    }
}