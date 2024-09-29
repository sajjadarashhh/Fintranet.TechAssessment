using Fintranet.TaxCalculatorCommon.Common.Enums;
using Fintranet.TaxCalculatorModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Fintranet.TaxCalculatorService.TaxCalculator.Commands
{
    public record VehicleTaxDetail(DateTime date, decimal price);
    public record VehicleTaxCalculatedDto(decimal tax, List<VehicleTaxDetail> detail);
    public record VehicleTaxCalculateDto(VehicleType vehicle, DateTime[] dates) : IRequest<VehicleTaxCalculatedDto>;

    public class VehicleTaxCalculator : IRequestHandler<VehicleTaxCalculateDto, VehicleTaxCalculatedDto>
    {

        private readonly CalculatorDataContext _db;

        public VehicleTaxCalculator(CalculatorDataContext db)
        {
            _db = db;
        }

        public async Task<VehicleTaxCalculatedDto> Handle(VehicleTaxCalculateDto request, CancellationToken cancellationToken)
        {
            List<VehicleTaxDetail> result = [];
            if (request.vehicle != VehicleType.Other)
                return new(0, []);
            var freeDates = await _db.Holidays.Where(a => request.dates.Any(b => a.Date.Year == b.Year && a.Date.Month == b.Month && a.Date.Day == b.Day)).Select(a => a.Date).ToListAsync();
            var datesToCalculate = request.dates
                .Where(a => freeDates.All(b => b.ToShortDateString() != a.ToShortDateString()) && a.DayOfWeek != DayOfWeek.Saturday && a.DayOfWeek != DayOfWeek.Sunday || a.Month == 7)
                .Order().ToList();
            var removedDates = request.dates.Except(datesToCalculate);
            var first = datesToCalculate[0];
            var last = datesToCalculate.Last();
            var rules = _db.TaxRules.ToList();
            var taxes = datesToCalculate.Select(dayEvent =>
            {
                var rule = rules.FirstOrDefault(a => a.StartTime <= dayEvent.TimeOfDay && a.EndTime >= dayEvent.TimeOfDay);
                if (rule is null)
                    return new VehicleTaxDetail(dayEvent, 0);
                return new VehicleTaxDetail(dayEvent, rule!.TaxRate);
            }).ToList();
            int i = 0;
            do
            {
                var item = taxes[i];
                if (!CheckTaxRemovingRule(taxes, item!))
                {
                    result.Add(item);
                    i++;
                }
            } while (taxes.Count > i);
            return new VehicleTaxCalculatedDto(result.Sum(b => b.price), [.. result, .. removedDates.Select(b => new VehicleTaxDetail(b, 0))]);
        }
        public bool CheckTaxRemovingRule(List<VehicleTaxDetail> taxes, VehicleTaxDetail current)
        {
            var itemsInRange = taxes.Where(a => a.date > current.date && a.date <= current.date.AddHours(1));
            var maxItemAfterCurrent = itemsInRange.MaxBy(a => a.price);
            if (maxItemAfterCurrent is null)
                return false;
            if (current.price <= maxItemAfterCurrent!.price)
            {
                var checkSubItemRemoval = CheckTaxRemovingRule(taxes, maxItemAfterCurrent);
                if (!checkSubItemRemoval)
                {
                    taxes.Remove(current);
                    return true;
                }
            }
            return false;
        }

    }
}
