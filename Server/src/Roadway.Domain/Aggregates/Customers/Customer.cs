using Roadway.Domain.Contracts;

namespace Roadway.Domain.Aggregates.Customers
{
    public class Customer : BaseEntity, IAggregateRoot
    {
        public Customer(
            string firstName,
            string middleName,
            string lastName,
            string secondLastName
        )
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            SecondLastName = secondLastName;
        }

        public string FirstName { get; }

        public string MiddleName { get; }

        public string LastName { get; }

        public string SecondLastName { get; }
    }
}