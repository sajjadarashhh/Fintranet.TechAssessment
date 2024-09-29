using Fintranet.TaxCalculatorModel.Tables.Holidays;
using Fintranet.TaxCalculatorModel.Tables.Taxes;
using Fintranet.TaxCalculatorModel.Tables.Vehicles;
using Microsoft.EntityFrameworkCore;

namespace Fintranet.TaxCalculatorModel
{
    public class CalculatorDataContext : DbContext
    {
        public CalculatorDataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TaxModel> Taxes { get; set; }
        public DbSet<TaxRuleModel> TaxRules { get; set; }
        public DbSet<HolidayModel> Holidays { get; set; }
        public DbSet<VehicleTaxModel> VehicleTaxes { get; set; }
        public DbSet<VehicleModel> Vehicles { get; set; }
    }
}
