namespace RetailPulse.Domain.Exceptions;


// Base exception for all domain rule violations.
// Thrown when business rules are broken inside entities or aggregates.
public class DomainException : System.Exception
{
    public DomainException(string message) : base(message)
    {
        
    }
}