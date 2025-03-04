using CleanCode.Domain.Common;

namespace CleanCode.Domain.Entities
{
    public record User : RecordBase
    {
        public Address Address { get; set; } = new Address();
        public ContactInformation Contact { get; set; } = new ContactInformation();
    }
}
