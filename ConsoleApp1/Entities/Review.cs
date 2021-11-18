using ConsoleApp1.Enums;

namespace ConsoleApp1.Entities
{
    public abstract class Review : BaseEntity
    {
        public long UserFk { get; set; }

        public Rating Rating { get; set; }

        public string Text { get; set; }

        // NAVIGATION
        public ApplicationUser ApplicationUser { get; set; }
    }
}
