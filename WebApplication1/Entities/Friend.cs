using ConsoleApp1.Enums;

namespace ConsoleApp1.Entities
{
    public class Friend : BaseEntity
    {
        public long InviteToFk { get; set; }

        public long InviteByFk { get; set; }

        public FriendInviteStatus InviteStatus { get; set; }

        public ApplicationUser Inviter { get; set; }

        public ApplicationUser Invetee { get; set; }
    }
}
