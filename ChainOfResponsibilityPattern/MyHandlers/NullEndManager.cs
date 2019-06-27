using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.MyHandlers
{
    class NullEndManager : BankWorker, IHandler
    {
        protected IHandler _nextLink;
        public bool Handle(LoanRequest request)
        {
            return false;
        }

        public IHandler SetNext(IHandler nextHandler)
        {
            _nextLink = nextHandler;
            return _nextLink;
        }
    }
}
