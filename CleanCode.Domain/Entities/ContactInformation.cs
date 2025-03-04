using CleanCode.Domain.Common;

namespace CleanCode.Domain.Entities
{
    public record ContactInformation : RecordBase
    {
        public string Phone { get; set; } = string.Empty;
    }
}
