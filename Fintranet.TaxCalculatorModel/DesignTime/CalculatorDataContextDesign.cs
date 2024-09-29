using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Fintranet.TaxCalculatorModel.DesignTime
{
    public class CalculatorDataContextDesign : IDesignTimeDbContextFactory<CalculatorDataContext>
    {
        public CalculatorDataContext CreateDbContext(string[] args)
        {
            return new CalculatorDataContext(new DbContextOptionsBuilder<CalculatorDataContext>().UseSqlServer("server=localhost,1433;database=fintratest;uid=sa;pwd=#Sa@jjad@;trustservercertificate=true;").Options);
        }
    }
}
