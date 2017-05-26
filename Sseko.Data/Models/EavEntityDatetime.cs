﻿using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavEntityDatetime
    {
        public int ValueId { get; set; }
        public ushort AttributeId { get; set; }
        public int EntityId { get; set; }
        public ushort EntityTypeId { get; set; }
        public ushort StoreId { get; set; }
        public DateTime Value { get; set; }

        public virtual EavEntity Entity { get; set; }
        public virtual EavEntityType EntityType { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
