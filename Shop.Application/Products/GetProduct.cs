using Microsoft.EntityFrameworkCore;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Products
{
    public class GetProduct
    {
        private ApplicationDbContext _ctx;

        public GetProduct(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public ProductViewModels Do(string name) =>
            _ctx.Products
            .Include(x => x.Stock)
            .Where(x => x.Name == name)
            .Select(x => new ProductViewModels
            {
                Name = x.Name,
                Desctription = x.Desctription,
                Value = $"$ {x.Value.ToString("N2")}",
                
                Stock = x.Stock.Select(y => new StockViewMovel
                {
                    Id = y.Id,
                    Description =y.Description,
                    InStock = y.Qty > 0
                })
            })
            .FirstOrDefault();
        public class ProductViewModels
        {
            public string Name { get; set; }

            public string Desctription { get; set; }

            public string Value { get; set; }
            public IEnumerable<StockViewMovel> Stock { get; set; }
        }
        public class StockViewMovel
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public bool InStock { get; set; }
            
        }
    }
}
