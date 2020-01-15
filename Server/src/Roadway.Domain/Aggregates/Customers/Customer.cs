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
        
        public Customer(
            int id,
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
            Id = id;
        }

        private Customer()
        {
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string SecondLastName { get; set; }
    }
}