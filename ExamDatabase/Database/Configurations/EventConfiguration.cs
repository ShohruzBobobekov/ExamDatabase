using ExamDatabase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamDatabase.Database.Configurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.EventName)
            .HasMaxLength(200);
        builder.HasOne(e => e.Room)
            .WithMany(r => r.Events)
            .HasForeignKey(e => e.RoomId);

    }
}
