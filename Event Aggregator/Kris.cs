using System;

namespace Event_Aggregator_Pattern
{
    public class Kris : ISubscriber<GoalScored>
    {
        public string name { get; set; } = "Kris";

        public Kris(IEventAggregator ea)
        {
            ea.Subscribe(this);
        }

        public void OnEvent(GoalScored e)
        {
            Console.WriteLine($"{name} sees that {e.WhatHappened()}");
        }
    }
}