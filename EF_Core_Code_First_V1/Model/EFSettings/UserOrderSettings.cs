using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Code_First_V1.Model.EFSettings
{
    class UserOrderSettings: IEntityTypeConfiguration<UserOrder>
    {
        public void Configure(EntityTypeBuilder<UserOrder> builder)
        {
            builder.ToTable(nameof(UserOrder)).HasKey(x => x.UserOrderID);
            builder.Property(x => x.UserOrderID).ValueGeneratedOnAdd();
            builder.Property(x => x.Detail).IsRequired();
            builder.Property(x => x.Detail).HasMaxLength(40);
            builder.HasOne(x => x.User).WithMany().HasForeignKey(bc => bc.UserID);
            builder.HasOne(x => x.Order).WithMany().HasForeignKey(bc => bc.OrderID);

        }
    }
}
