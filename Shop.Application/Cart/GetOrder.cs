using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Shop.Application.Cart
{
    public class GetOrder
    {
        private ISession _session;
        private ApplicationDbContext _ctx;

        public GetOrder(ISession session, ApplicationDbContext ctx)
        {
            _session = session;
            _ctx = ctx;
        }

        public class Response
        {
            public IEnumerable<Product> Products { get; set; }
            public CustomerInformation CustomerInformation { get; set; }

            public int GetTotalCharge() => Products.Sum(x => x.Value * x.Qty);
        }

        public class Product
        {

            public int Value { get; set; }
            public int Qty { get; set; }
            public int StockId { get; set; }

            public int ProductId { get; set; }

        }

        public class CustomerInformation
        {

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }

            public string PhoneNumber { get; set; }

            public string Address1 { get; set; }

            public string Address2 { get; set; }

            public string City { get; set; }

            public string PostCode { get; set; }

        }

        public Response Do()
        {

            var cart = _session.GetString("cart");



            var cartList = JsonConvert.DeserializeObject<List<CartProduct>>(cart);

            //var listOfProducts = cartList.Select(item => _ctx.Stock
            //      .Include(x => x.Product)
            //      .Where(x => x.Id == item.StockId)
            //      .Select(x => new Product
            //      {
            //          ProductId = x.ProductId,
            //          StockId = item.StockId,
            //          Value = (int)(x.Product.Value * 100),
            //          Qty = cartList.FirstOrDefault(y => y.StockId == x.Id).Qty
            //      }).FirstOrDefault()).ToList();
            var itemsInCart = cartList.Select(x => x.StockId).ToList();

            var listOfProducts = _ctx.Stock
                  .Include(x => x.Product)
                  .Where(x => itemsInCart.Contains(x.Id))
                  .Select(x => new Product
                  {
                      ProductId = x.ProductId,
                      StockId = x.Id,
                      Value = (int)(x.Product.Value * 100),
                  }).ToList();
            listOfProducts.Select(x =>
            {
                x.Qty = cartList.FirstOrDefault(y => y.StockId == x.ProductId).Qty;
                return x;
            });


            var customerInfoString = _session.GetString("customer-info");

            var customerInformation = JsonConvert.DeserializeObject<Shop.Domain.Models.CustomerInformation>(customerInfoString);


            //var response = cartList.Select(item => _ctx.Stock.Include(x => x.Product)
            //        .Where(x => x.Id == item.StockId)
            //        .Select(x => new Response
            //        {
            //            Name = x.Product.Name,
            //            Value = $"$ {x.Product.Value.ToString("N2")}",
            //            StockId = item.StockId,
            //            Qty = item.Qty
            //        })
            //        .FirstOrDefault())
            //        .ToList();

            return new Response
            {
                Products = listOfProducts,
                CustomerInformation = new CustomerInformation
                {

                    FirstName = customerInformation.FirstName,
                    LastName = customerInformation.LastName,
                    Email = customerInformation.Email,
                    PhoneNumber = customerInformation.PhoneNumber,
                    Address1 = customerInformation.Address1,
                    Address2 = customerInformation.Address2,
                    City = customerInformation.City,
                    PostCode = customerInformation.PostCode
                }
            };


        }
    }
}

