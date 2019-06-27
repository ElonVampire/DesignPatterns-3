using ChainOfResponsibilityPattern.MyHandlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    interface IHandler
    {
        IHandler SetNext(IHandler nextHandler);
        bool Handle(LoanRequest request);
    }
}
