﻿using RestWithASPNET.Hypermedia;
using RestWithASPNET.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace RestWithASPNET.Data.VO
{
    public class BookVO : ISupportsHypermedia
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }        
        public decimal Price { get; set; }
        public DateTime launchDate { get; set; }
        public List<HypermediaLink> Links { get; set; } = new List<HypermediaLink>();
    }
}
