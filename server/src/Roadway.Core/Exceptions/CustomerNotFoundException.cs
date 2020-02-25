using System;

namespace Roadway.Core.Exceptions
{
    public class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException() : base("Customer not found")
        {
        }
    }
}