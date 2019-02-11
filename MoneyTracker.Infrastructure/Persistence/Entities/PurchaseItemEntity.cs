﻿using System;

namespace MoneyTracker.Infrastructure.Persistence.Entities
{
    public class PurchaseItemEntity
    {
        public Guid PurchaseId { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }

        public virtual PurchaseEntity Purchase { get; set; }
    }
}