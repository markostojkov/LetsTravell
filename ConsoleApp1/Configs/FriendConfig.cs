using ConsoleApp1.Entities;
using ConsoleApp1.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Configs
{
    public class FriendConfig : BaseConfig<Friend>
    {
        public FriendConfig(string schema) : base(schema)
        {
        }

        public override void Configure(EntityTypeBuilder<Friend> builder)
        {
            base.Configure(builder);

            builder.ToTable("Friend", Schema);

            builder.Property(x => x.InviteToFk).HasColumnName(@"InviteToFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.InviteByFk).HasColumnName(@"InviteByFk").HasColumnType("bigint").IsRequired();
            builder.Property(x => x.InviteStatus).HasColumnName(@"InviteStatus").HasColumnType("tinyint").IsRequired().HasDefaultValue(FriendInviteStatus.Invited);

            builder.HasOne(x => x.Invetee).WithMany().HasForeignKey(x => x.InviteToFk).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Inviter).WithMany().HasForeignKey(x => x.InviteByFk).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
