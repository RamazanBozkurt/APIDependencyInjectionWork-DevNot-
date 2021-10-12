using DependencyInjectionOdev.Models.Abstract;
using DependencyInjectionOdev.Models.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IContext context;
        private readonly ISmsSenderService smsSender;
        private readonly IDbService db;
        private readonly ICreditCartService creditCart;

        public OrderController(IContext context, ISmsSenderService smsSender, IDbService db, ICreditCartService creditCart)
        {
            this.context = context;
            this.smsSender = smsSender;
            this.db = db;
            this.creditCart = creditCart;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = context.GetOrders();
            if(orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder([FromQuery]int id)
        {
            var order = context.GetOrders().FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost]
        public IActionResult AddOrder([FromBody]Order order)
        {
            if (ModelState.IsValid)
            {
                var orders = context.GetOrders();
                orders.Add(order);
                return CreatedAtAction(nameof(GetOrder), new { id = order.Id}, null);
                //int id = order.Id;
                //return Created($"~/api/orders/{id}", order);
            }
            return BadRequest(ModelState);
        }

        [HttpGet("Arrived/")]
        public IActionResult ArrivedOrder()
        {
            smsSender.Send();
            db.GetData();
            creditCart.RequestCartInformation();
            return Ok();
        }
    }
}
