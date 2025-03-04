namespace CleanCode.Domain.Common
{
    public abstract record RecordBase
    {
        public Guid UID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset? LastModified { get; set; }
    }
}
