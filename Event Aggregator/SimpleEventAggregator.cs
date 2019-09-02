using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Event_Aggregator_Pattern
{
    public class SimpleEventAggregator : IEventAggregator
    {
        private readonly Dictionary<Type, List<WeakReference>> _eventSubscriberLists =
            new Dictionary<Type, List<WeakReference>>();
        private readonly object _lock = new object();

        public void Publish<TEvent>(TEvent eventToPublish) where TEvent : IEvent
        {
            var subscriberType = typeof(ISubscriber<>).MakeGenericType(typeof(TEvent));
            var subscribers = GetSubscribers(subscriberType);
            List<WeakReference> subscriberstoRemove   = new List<WeakReference>();

            foreach (var weakSubscriber in subscribers)
            {
                if(weakSubscriber.IsAlive)
                {
                    var subscriber = (ISubscriber<TEvent>)weakSubscriber.Target;
                    var syncContext = SynchronizationContext.Current;
                    if(syncContext == null)
                    {
                        syncContext = new SynchronizationContext();
                    }
                    syncContext.Post(s => subscriber.OnEvent(eventToPublish), null);

                }
                else
                {
                    subscriberstoRemove.Add(weakSubscriber);
                }
            }

            if (subscriberstoRemove.Any())
            {
                lock(_lock){
                    foreach (var remove in subscriberstoRemove)
                    {
                        subscribers.Remove(remove);
                    }
                }
            }
        }

        public void Subscribe(object subscriber)
        {
            lock (_lock)
            {
                var subscriberTypes = subscriber.GetType().GetInterfaces().Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ISubscriber<>));
                var weakreference = new WeakReference(subscriber);
                foreach (var subType in subscriberTypes)
                {
                    var subscribers = GetSubscribers(subType);
                    subscribers.Add(weakreference);
                }
            }
        }

        private List<WeakReference> GetSubscribers(Type subType)
        {
            List<WeakReference> subscribers;
            lock (_lock)
            {
                var found = _eventSubscriberLists.TryGetValue(subType, out subscribers);
                if (!found)
                {
                    subscribers = new List<WeakReference>();
                    _eventSubscriberLists.Add(subType, subscribers);
                }
            }
            return subscribers;
        }
    }
}