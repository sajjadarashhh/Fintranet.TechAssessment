using Fintranet.TaxCalculatorCommon.EFAbstracts.ModelBase;
using Fintranet.TaxCalculatorModel.Tables.Taxes;

namespace Fintranet.TaxCalculatorModel.Tables.Vehicles
{
    public class VehicleTaxModel:DbValueObjectBase
    {
        public Guid VehicleId { get; set; }
        public Guid TaxId { get; set; }
        public VehicleModel? Vehicle { get; set; }
        public TaxModel? Tax { get; set; }
    }
}
