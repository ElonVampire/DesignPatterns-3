using ChainOfResponsibilityPattern.MyHandlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    class IsAbleToApproveLoanAmountCommand : ICommand
    {
        protected LoanRequest _request;
        protected BankWorker _worker;

        public IsAbleToApproveLoanAmountCommand(LoanRequest request, BankWorker worker)
        {
            _request = request;
            _worker = worker;
        }
        public bool Execute()
        {
            if (_request.LoanRequired <= _worker.loanLimit)
            {
                if (_request.InterestOverride)
                {
                    if (_worker.hasInterestOverride)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
