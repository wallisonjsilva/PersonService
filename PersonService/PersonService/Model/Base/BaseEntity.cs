using System.ComponentModel.DataAnnotations.Schema;

namespace PersonService.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}