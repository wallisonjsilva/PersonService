using System;

namespace PersonService.Data.VO
{
    public class BookVO
    {
        public long Id { get; set; }
        
        public string author { get; set; }

        public DateTime launchDate { get; set; }

        public decimal price { get; set; }
        
        public string title { get; set; }
    }
}