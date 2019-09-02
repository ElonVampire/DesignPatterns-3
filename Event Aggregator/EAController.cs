using System;
using System.Threading;

namespace Event_Aggregator_Pattern
{
    public class EAController
    {
        public IEventAggregator eventAggregator { get; set; }
        public Thomas sub1;
        public Kris sub2;


        public EAController()
        {
            eventAggregator = new SimpleEventAggregator();
            sub1 = new Thomas(eventAggregator);
            sub2 = new Kris(eventAggregator);
        }

        internal void RunProgram()
        {
            int counter = 1;
            while (true)
            {
                counter++;
                for(int i = 0; i <= 3; i++)
                {
                    eventAggregator.Publish(new BallKicked
                    {
                        direction = "north",
                        playerWhoKicked = "Jeff"
                    });
                    Thread.Sleep(1000);
                    eventAggregator.Publish(new BallKicked
                    {
                        direction = "east",
                        playerWhoKicked = "phil"
                    });
                    Thread.Sleep(1000);
                    eventAggregator.Publish(new BallKicked
                    {
                        direction = "north",
                        playerWhoKicked = "Jeff"
                    });
                    Thread.Sleep(1000);
                }
                eventAggregator.Publish(new GoalScored
                {
                    minutesIntoGame = counter,
                    playerWhoScored = "phil"
                });
                Thread.Sleep(3000);

            }
        }
    }
}