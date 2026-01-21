

namespace DevFlix.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;

        public bool IsActive { get; private set; } = true;
        public DateTime CreateDateTime { get; private set; } = DateTime.UtcNow;

        public Category(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            CreateDateTime = DateTime.UtcNow;
        }
    }
}
