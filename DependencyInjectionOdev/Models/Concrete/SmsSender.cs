using DependencyInjectionOdev.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Models.Concrete
{
    public class SmsSender : ISmsSenderService
    {
        public void Send()
        {
            Console.WriteLine("SMS müşteriye iletilmiştir.");
        }
    }
}
