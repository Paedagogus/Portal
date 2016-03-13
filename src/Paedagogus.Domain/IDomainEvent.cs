namespace Paedagogus.Domain
{
    using System;
    
    public interface IDomainEvent
    {
        int Version { get; }
        
        DateTime CreatedOnUtc { get; }
    }
}