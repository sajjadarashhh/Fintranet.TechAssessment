
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fintranet.TaxCalculatorCommon.EFAbstracts.ModelBase
{
    public abstract class DbEntityBase<TId> where TId : notnull
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public TId Id { get; set; } = default!;
    }
}
