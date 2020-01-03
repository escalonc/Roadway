namespace Roadway.Domain.CustomersAggregate
{
    public class Customer : BaseEntity, IAggregateRoot
    {
        public string FirstName { get; }
        
        public string MiddleName { get; }
        
        public string LastName { get; }
        
        public string SecondLastName { get; }
    }
}