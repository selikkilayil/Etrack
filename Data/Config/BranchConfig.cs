using Core.Entities.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Config
{
    public class BranchConfig : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Branches)
                .HasForeignKey(n => n.CustomerId).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Name).HasMaxLength(100);
        }
    }
}
