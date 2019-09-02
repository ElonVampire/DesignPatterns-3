namespace Event_Aggregator_Pattern
{
    public interface IEventAggregator
    {
        void Subscribe(object subscriber);
        void Publish<TEvent>(TEvent eventToPublish) where TEvent : IEvent;
    }

    public interface IEvent
    {
        string WhatHappened();
    }

    public class GoalScored : IEvent
    {
        public string playerWhoScored { get; set; }
        public int minutesIntoGame { get; set; }

        public string WhatHappened()
        {
            return $"{playerWhoScored} scored a goal at minute {minutesIntoGame}";
        }
    }

    public class BallKicked : IEvent
    {
        public string playerWhoKicked { get; set; }
        public string direction { get; set; }

        public string WhatHappened()
        {
            return $"{playerWhoKicked} kicked the ball {direction}";
        }
    }
}