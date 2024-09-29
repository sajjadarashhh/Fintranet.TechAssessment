using Fintranet.TaxCalculatorCommon.EFAbstracts.ModelBase;

namespace Fintranet.TaxCalculatorModel.Tables.Holidays
{
    public class HolidayModel:DbEntityBase<Guid>
    {
        public DateOnly Date { get; set; }
    }
}
