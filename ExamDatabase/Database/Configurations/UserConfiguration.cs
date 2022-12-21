using ExamDatabase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamDatabase.Database.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);

        builder
            .Property(user => user.UserName)
            .HasMaxLength(60);
        builder
            .Property(user => user.Password)
            .HasMaxLength(16);
        builder
             .HasMany(user => user.Plases)
             .WithOne(plase => plase.User)
             .HasForeignKey(plase=>plase.UserId);
    }
}
