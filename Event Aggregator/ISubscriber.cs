namespace Event_Aggregator_Pattern
{
    public interface ISubscriber<T>
    {
        void OnEvent(T e);
    }
}