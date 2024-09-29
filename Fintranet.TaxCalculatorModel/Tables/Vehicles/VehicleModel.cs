using Fintranet.TaxCalculatorCommon.EFAbstracts.ModelBase;

namespace Fintranet.TaxCalculatorModel.Tables.Vehicles
{
    public enum VehicleType
    {
        Emergency,
        Busses,
        Diploman,
        MotorCycles,
        Military,
        Foreign,
        Other
    }
    public class VehicleModel : DbEntityBase<Guid>
    {
        public string Plaque { get; set; } = null!;
        public VehicleType Type { get; set; }
    }
}
