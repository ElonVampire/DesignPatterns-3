using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.MyHandlers
{
    class BranchManager : BankWorker, IHandler
    {
        protected IHandler _nextLink;

        public BranchManager()
        {
            loanLimit = 10000;
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
