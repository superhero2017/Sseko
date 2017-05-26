﻿using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductIndexPriceCfgOptAgrTmp
    {
        public int ParentId { get; set; }
        public int ChildId { get; set; }
        public ushort CustomerGroupId { get; set; }
        public ushort WebsiteId { get; set; }
        public decimal? GroupPrice { get; set; }
        public decimal? Price { get; set; }
        public decimal? TierPrice { get; set; }
    }
}
