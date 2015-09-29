﻿using System;

namespace Domains.EventSourcing.Infrastructure
{
    public class OrderEvent
    {
        public long Id { get; set; }
        public Guid AggregateId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
    }
}