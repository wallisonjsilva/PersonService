using System;
using System.Collections.Generic;
using PersonService.Hypermedia;
using PersonService.Hypermedia.Abstract;

namespace PersonService.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        
        public string author { get; set; }

        public DateTime launchDate { get; set; }

        public decimal price { get; set; }
        
        public string title { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}