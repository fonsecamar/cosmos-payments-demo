﻿using System;

namespace cosmos_payments_demo.Model
{
    public class Transaction
    {
        public Transaction()
        {
            this.id = Guid.NewGuid().ToString();
            this.timestamp= DateTime.UtcNow;
        }
        public string id { get; set; }
        public string accountId { get; set; }
        public string description { get; set; }
        public string merchant { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
        public DateTime timestamp { get; set; }
    }
}
