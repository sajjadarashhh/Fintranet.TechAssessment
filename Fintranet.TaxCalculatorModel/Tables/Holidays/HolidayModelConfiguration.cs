using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Fintranet.TaxCalculatorModel.Tables.Holidays
{
    public class HolidayModelConfiguration : IEntityTypeConfiguration<HolidayModel>
    {
        public void Configure(EntityTypeBuilder<HolidayModel> builder)
        {
            builder.HasData(SeedLargData());
        }

        public List<HolidayModel> SeedLargData()
        {
            var publications = new List<HolidayModel>()
            {
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,1,1),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,3,27),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,3,28),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,3,29),
                },
                new HolidayModel()
                {Id = Guid.NewGuid(),
                    Date=new DateOnly(2013,3,31),
                },
                new HolidayModel()
                {Id = Guid.NewGuid(),
                    Date=new DateOnly(2013,4,1),
                },
                new HolidayModel()
                {Id = Guid.NewGuid(),
                    Date=new DateOnly(2013,4,29),
                },
                new HolidayModel()
                {Id = Guid.NewGuid(),
                    Date=new DateOnly(2013,4,30),
                }, 
                new HolidayModel()
                {Id = Guid.NewGuid(),
                    Date=new DateOnly(2013,5,1),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,5,7),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,5,8),
                },
                new HolidayModel()
                {Id = Guid.NewGuid(),
                    Date=new DateOnly(2013,5,9),
                },
                new HolidayModel()
                {Id = Guid.NewGuid(),
                    Date=new DateOnly(2013,6,4),
                },
                new HolidayModel()
                {Id = Guid.NewGuid(),
                    Date=new DateOnly(2013,6,5),
                },
                new HolidayModel()
                {Id = Guid.NewGuid(),
                    Date=new DateOnly(2013,6,6),
                },
                new HolidayModel()
                {Id = Guid.NewGuid(),
                    Date=new DateOnly(2013,6,20),
                },
                new HolidayModel()
                {Id = Guid.NewGuid(),   
                    Date=new DateOnly(2013,6,21),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,10,31),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,11,1),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,12,23),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,12,24),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,12,25),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,12,26),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,12,30),
                },
                new HolidayModel()
                {
                    Id=Guid.NewGuid(),
                    Date=new DateOnly(2013,12,31),
                }
            };
            return publications!;
        }
    }
}
