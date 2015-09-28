﻿using System;
using System.Linq;
using Domain.Base;
using Domains.Compromise.Domain;
using Domains.Compromise.Infrastructure.EntityFramework;

namespace Domains.Compromise.Infrastructure
{
    public class OrderRepository : IRepository<Order>
    {
        public Order Get(Guid id)
        {
            using (var dataContext = new DataContext()) {
                return dataContext.Set<Order>().Include("Lines").FirstOrDefault(x => x.Id == id);
            }
        }

        public void Add(Order order)
        {
            using (var dataContext = new DataContext()) {
                dataContext.Set<Order>().Add(order);
                dataContext.SaveChanges();
            }
        }
    }
}