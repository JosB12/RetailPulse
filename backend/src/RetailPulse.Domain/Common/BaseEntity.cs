namespace RetailPulse.Domain.Common;
// Abstract Class
// Serves as the base template for all domain entities.
// Base class for all domain entities.
// Every entity has an Id and tracks domain events
// that will be published after the transaction commits.
public abstract class BaseEntity
{
    // Property
    // Unique identifier of the entity.
    // Can be read from anywhere (public get),
    // but can only be modified by this class or derived classes (protected set).
    public Guid Id { get; protected set; }

    // Private Field
    // Internal list used to store domain events.
    // readonly means the list reference cannot be reassigned,
    // although items can still be added or removed.
    private readonly List<IDomainEvent> _domainEvents = [];

    // Read-Only Property
    // Exposes domain events in a safe way.
    // IReadOnlyCollection prevents external code from modifying the collection.
    public IReadOnlyCollection<IDomainEvent> DomainEvents
        => _domainEvents.AsReadOnly();

    // Protected Method
    // Can only be called by BaseEntity or classes that inherit from it.
    // Used to register a new domain event.
    protected void AddDomainEvent(IDomainEvent domainEvent)
    {
        // Parameter: domainEvent
        // Field: _domainEvents
        _domainEvents.Add(domainEvent);
    }

    // Public Method
    // Clears all registered domain events.
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
