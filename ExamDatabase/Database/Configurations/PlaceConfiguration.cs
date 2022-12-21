
using ExamDatabase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamDatabase.Database.Configurations;

public class PlaceConfiguration : IEntityTypeConfiguration<RecervedPlase>
{
    public void Configure(EntityTypeBuilder<RecervedPlase> builder)
    {
        builder.HasKey(x => new { x.EventId, x.UserId });
    }
}
