using Fintranet.TaxCalculatorCommon.EFAbstracts.ModelBase;

namespace Fintranet.TaxCalculatorModel.Tables.Taxes
{
    public class TaxRuleModel:DbEntityBase<Guid>
    {
        public decimal TaxRate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
