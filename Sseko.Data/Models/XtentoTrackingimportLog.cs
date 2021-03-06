﻿using System;

namespace Sseko.Data.Models
{
    public partial class XtentoTrackingimportLog
    {
        public int LogId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Files { get; set; }
        public string ImportEvent { get; set; }
        public int ImportType { get; set; }
        public int ProfileId { get; set; }
        public int RecordsImported { get; set; }
        public int Result { get; set; }
        public string ResultMessage { get; set; }
        public string SourceIds { get; set; }
    }
}
