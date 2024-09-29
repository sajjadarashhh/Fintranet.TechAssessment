using Fintranet.TaxCalculatorModel.Tables.Holidays;
using Fintranet.TaxCalculatorModel.Tables.Taxes;
using Fintranet.TaxCalculatorModel.Tables.Taxs;
using Microsoft.EntityFrameworkCore;

namespace Fintranet.TaxCalculatorModel
{
    public class CalculatorDataContext : DbContext
    {
        public CalculatorDataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TaxRuleModel> TaxRules { get; set; }

        /// <summary>
        /// you will save tax free dates like holidays and day before holiday
        /// </summary>
        public DbSet<HolidayModel> Holidays { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaxRuleModelConfiguration());
            modelBuilder.ApplyConfiguration(new HolidayModelConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
