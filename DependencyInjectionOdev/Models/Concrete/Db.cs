using DependencyInjectionOdev.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Models.Concrete
{
    public class Db : IDbService
    {
        public void Add()
        {
            Console.WriteLine("INFO : CREATED");
        }

        public void GetData()
        {
            Console.WriteLine("INFO : READED");
        }

        public void Update()
        {
            Console.WriteLine("INFO : UPDATED");
        }
    }
}
