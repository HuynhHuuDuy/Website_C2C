using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BeYourMarket.Model.Models.Mapping
{
    public class OrderBuyCoinMap : EntityTypeConfiguration<OrderBuyCoin>
    {
        public OrderBuyCoinMap()
        {
            //Primary Key
            this.HasKey(t => t.ID);

            //Properties

            // Table & Column Mappings
            this.ToTable("OrderBuyCoins");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Coins).HasColumnName("Coins");
            this.Property(t => t.UserBuyCoin).HasColumnName("UserBuyCoin");

            // Relationships
            this.HasRequired(t => t.AspNetUserBuyCoin)
            .WithMany(t => t.OrdersBuyCoins)
            .HasForeignKey(t => t.UserBuyCoin);
        }
    }
}
