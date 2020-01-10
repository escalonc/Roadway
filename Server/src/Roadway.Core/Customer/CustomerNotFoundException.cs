using System;

namespace Roadway.Core.Customer
{
    public class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException() : base("Customer not found")
        {
        }
    }
}