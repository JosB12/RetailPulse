namespace RetailPulse.Domain.Common;

// Marker interface for all domain events.
// Kept pure — no external dependencies.
// MediatR's INotification is applied in the Application layer
// where domain events are wrapped and dispatched.
public interface IDomainEvent
{
    Guid EventId {get;}
    DateTime OcurredAt {get;}

}
