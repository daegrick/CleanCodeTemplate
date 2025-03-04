namespace CleanCode.Application.Features.Users
{
    public record UserVm
    {
        public Guid UID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
