using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Models.Abstract
{
    public interface IDbService
    {
        void GetData();
        void Add();
        void Update();
    }
}
