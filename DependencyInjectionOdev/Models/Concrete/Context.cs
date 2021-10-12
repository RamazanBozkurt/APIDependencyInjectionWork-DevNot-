using DependencyInjectionOdev.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Models.Concrete
{
    public class Context : IContext
    {
        public readonly List<Order> orders = new List<Order>
        {
            new Order {Id=1, Name = "Test1", OwnerName = "Owner1"},
            new Order {Id=2, Name = "Test2", OwnerName = "Owner2"},
            new Order {Id=3, Name = "Test3", OwnerName = "Owner3"},
            new Order {Id=4, Name = "Test4", OwnerName = "Owner4"},
            new Order {Id=5, Name = "Test5", OwnerName = "Owner5"}
        };

        public IList<Order> GetOrders()
        {
            return orders;
        }
    }
}
