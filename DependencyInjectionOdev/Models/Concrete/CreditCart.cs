using DependencyInjectionOdev.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Models.Concrete
{
    public class CreditCart : ICreditCartService
    {
        public void RequestCartInformation()
        {
            Console.WriteLine("Lütfen kredi kartı bilgilerinizi giriniz...");
        }
    }
}
