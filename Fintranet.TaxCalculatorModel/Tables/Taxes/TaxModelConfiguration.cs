using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Fintranet.TaxCalculatorModel.Tables.Taxes;

namespace Fintranet.TaxCalculatorModel.Tables.Taxs
{
    public class TaxRuleModelConfiguration : IEntityTypeConfiguration<TaxRuleModel>
    {
        public void Configure(EntityTypeBuilder<TaxRuleModel> builder)
        {
            builder.HasData(SeedLargData());
            builder.Property(a => a.TaxRate).HasPrecision(3);
        }

        public List<TaxRuleModel> SeedLargData()
        {
            var publications = new List<TaxRuleModel>()
            {
                new TaxRuleModel()
                {
                    Id=Guid.NewGuid(),
                    StartTime=TimeSpan.FromHours(6),
                    EndTime=TimeSpan.FromHours(6).Add(TimeSpan.FromMinutes(29)),
                    TaxRate=8
                },
                new TaxRuleModel()
                {
                    Id=Guid.NewGuid(),
                    StartTime=TimeSpan.FromHours(6.5),
                    EndTime=TimeSpan.FromHours(6).Add(TimeSpan.FromMinutes(59)),
                    TaxRate=13
                },
                new TaxRuleModel()
                {
                    Id=Guid.NewGuid(), 
                    StartTime=TimeSpan.FromHours(7),
                    EndTime=TimeSpan.FromHours(7).Add(TimeSpan.FromMinutes(59)),
                    TaxRate=18
                },
                new TaxRuleModel()
                {
                    Id=Guid.NewGuid(),
                    StartTime=TimeSpan.FromHours(8),
                    EndTime=TimeSpan.FromHours(8).Add(TimeSpan.FromMinutes(29)),
                    TaxRate=13
                },
                new TaxRuleModel()
                {
                    Id=Guid.NewGuid(),
                    StartTime=TimeSpan.FromHours(8.5),
                    EndTime=TimeSpan.FromHours(14).Add(TimeSpan.FromMinutes(59)),
                    TaxRate=8
                },
                new TaxRuleModel()
                {
                    Id=Guid.NewGuid(),
                    StartTime=TimeSpan.FromHours(15),
                    EndTime=TimeSpan.FromHours(15).Add(TimeSpan.FromMinutes(29)),
                    TaxRate=13
                },
                new TaxRuleModel()
                {
                    Id=Guid.NewGuid(),
                    StartTime=TimeSpan.FromHours(15.5),
                    EndTime=TimeSpan.FromHours(16).Add(TimeSpan.FromMinutes(59)),
                    TaxRate=18
                },
                new TaxRuleModel()
                {
                    Id=Guid.NewGuid(),
                    StartTime=TimeSpan.FromHours(17),
                    EndTime=TimeSpan.FromHours(17).Add(TimeSpan.FromMinutes(59)),
                    TaxRate=13
                },
                new TaxRuleModel()
                {
                    Id=Guid.NewGuid(),
                    StartTime=TimeSpan.FromHours(18),
                    EndTime=TimeSpan.FromHours(18).Add(TimeSpan.FromMinutes(29)),
                    TaxRate=8
                },
            };
            return publications!;
        }
    }
}
