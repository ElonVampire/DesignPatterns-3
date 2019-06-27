using ChainOfResponsibilityPattern.MyHandlers;

namespace ChainOfResponsibilityPattern
{
    internal class ExecutiveManager : BankWorker, IHandler
    {
        protected IHandler _nextLink;

        public ExecutiveManager()
        {
            loanLimit = 10000;
            hasInterestOverride = true;
        }

        public bool Handle(LoanRequest request)
        {
            if (new IsAbleToApproveLoanAmountCommand(request, this).Execute())
            {
                return true;
            }
            else
            {
                return _nextLink.Handle(request);
            }
        }

        public IHandler SetNext(IHandler nextHandler)
        {
            _nextLink = nextHandler;
            return _nextLink;
        }
    }
}
