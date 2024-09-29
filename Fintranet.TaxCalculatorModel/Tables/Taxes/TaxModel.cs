using Fintranet.TaxCalculatorCommon.EFAbstracts.ModelBase;
using Fintranet.TaxCalculatorModel.Tables.Vehicles;

namespace Fintranet.TaxCalculatorModel.Tables.Taxes
{
    public class TaxModel : DbEntityBase<Guid>
    {
        public double Tax { get; set; }
        public Guid VehicleId { get; set; }
        public VehicleModel? Vehicle { get; set; }
    }
}
