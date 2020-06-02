using ModeloDDD.Shared.ValueObject;

namespace ModeloDDD.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string email)
        {
            _Email = email;
        }
        public string _Email { get; private set; }
    }
}
