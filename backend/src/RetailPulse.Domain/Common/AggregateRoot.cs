namespace RetailPulse.Domain.Common;

// Aggregate root is the entry point to an aggregate.
// External code can only interact with the aggregate through this class,
// never directly with child entities like OrderItem.
public abstract class AggregateRoot : BaseEntity
{
    public int Version { get; protected set; }
}