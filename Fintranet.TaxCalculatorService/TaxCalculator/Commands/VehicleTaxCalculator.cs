using Fintranet.TaxCalculatorModel;
using MediatR;

namespace Fintranet.TaxCalculatorService.TaxCalculator.Commands
{
    public record VehicleTaxDetail(DateTime date, decimal price);
    public record VehicleTaxCalculatedDto(decimal tax, List<VehicleTaxDetail> detail);
    public record VehicleTaxCalculateDto(string plaque, DateTime date) : IRequest<VehicleTaxCalculatedDto>;
    public class VehicleTaxCalculator : IRequestHandler<VehicleTaxCalculateDto, VehicleTaxCalculatedDto>
    {
        private readonly CalculatorDataContext _db;

        public VehicleTaxCalculator(CalculatorDataContext db)
        {
            _db = db;
        }

        public async Task<VehicleTaxCalculatedDto> Handle(VehicleTaxCalculateDto request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
