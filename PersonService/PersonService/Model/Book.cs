using System;
using System.ComponentModel.DataAnnotations.Schema;
using PersonService.Model.Base;

namespace PersonService.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
        [Column("author")]
        public string author { get; set; }
     
        [Column("launch_date")]
        public DateTime launchDate { get; set; }
        
         [Column("price")]
        public decimal price { get; set; }
        
         [Column("title")]
        public string title { get; set; }
    }
}