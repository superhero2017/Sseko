﻿namespace Sseko.Data.Models
{
    public partial class CatalogProductLinkAttributeVarchar
    {
        public int ValueId { get; set; }
        public int LinkId { get; set; }
        public ushort ProductLinkAttributeId { get; set; }
        public string Value { get; set; }

        public virtual CatalogProductLink Link { get; set; }
        public virtual CatalogProductLinkAttribute ProductLinkAttribute { get; set; }
    }
}
