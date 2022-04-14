﻿using RestWithASPNET.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithASPNET.Hypermedia.Filters
{
    public class HypermediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
