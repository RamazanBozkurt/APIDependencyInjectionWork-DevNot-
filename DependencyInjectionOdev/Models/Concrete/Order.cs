using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Models.Concrete
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Sipariş adı alanının dolurulması zorunludur.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Sipariş sahibi alanının dolurulması zorunludur.")]
        public string OwnerName { get; set; }
    }
}
