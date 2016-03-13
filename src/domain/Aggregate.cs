namespace thrownewexception.com.domain
{
    using System;
    using System.Collections.Generic;

    public abstract class Aggregate
    {
        public readonly List<IDomainEvent> uncommittedEvents = new List<IDomainEvent>();
        public int unsavedVersion = 0;
        
        private readonly IDictionary<Type, Action<object>> handlers = new Dictionary<Type, Action<object>>();
        
        protected void RaiseEvent(IDomainEvent @event)
        {
            this.uncommittedEvents.Add(@event);
            Action<object> apply = null;
            if(!handlers.TryGetValue(@event.GetType(), out apply))
            {
                //TODO: create specific exception to throw in this situation
                throw new Exception($"Handler not found for event type: {@event.GetType()}");
            }
            
            apply.Invoke(@event);
        }
        
        protected void Register<T>(Action<T> action)
        {
            handlers.Add(typeof(T), @event => action((T)@event));
        }
    }
}