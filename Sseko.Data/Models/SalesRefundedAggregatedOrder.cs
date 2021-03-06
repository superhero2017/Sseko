﻿using System;

namespace Sseko.Data.Models
{
    public partial class SalesRefundedAggregatedOrder
    {
        public int Id { get; set; }
        public decimal? OfflineRefunded { get; set; }
        public decimal? OnlineRefunded { get; set; }
        public string OrderStatus { get; set; }
        public int OrdersCount { get; set; }
        public DateTime? Period { get; set; }
        public decimal? Refunded { get; set; }
        public ushort? StoreId { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
