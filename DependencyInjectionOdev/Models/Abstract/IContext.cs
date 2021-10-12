using DependencyInjectionOdev.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Models.Abstract
{
    public interface IContext
    {
        IList<Order> GetOrders();
    }
}
