using Fintranet.TaxCalculatorCommon.EFAbstracts.ModelBase;
using Fintranet.TaxCalculatorModel.Tables.Taxes;
using Microsoft.EntityFrameworkCore;

namespace Fintranet.TaxCalculatorModel.Tables.Vehicles
{
    [PrimaryKey(nameof(VehicleId), nameof(TaxId))]
    public class VehicleTaxModel:DbValueObjectBase
    {
        public Guid VehicleId { get; set; }
        public Guid TaxId { get; set; }
        public VehicleModel? Vehicle { get; set; }
        public TaxModel? Tax { get; set; }
    }
}
