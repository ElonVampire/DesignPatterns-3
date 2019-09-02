using System;

namespace Event_Aggregator_Pattern
{
    public class Thomas : ISubscriber<BallKicked>, ISubscriber<GoalScored>
    {
        public string name { get; set; } = "Thomas";

        public Thomas(IEventAggregator ea)
        {
            ea.Subscribe(this);
        }

        public void OnEvent(GoalScored e)
        {
            Console.WriteLine($"{name} sees that {e.WhatHappened()}");
        }

        public void OnEvent(BallKicked e)
        {
            Console.WriteLine($"{name} sees that {e.WhatHappened()}");
        }
    }
}