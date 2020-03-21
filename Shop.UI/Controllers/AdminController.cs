using Microsoft.AspNetCore.Mvc;
using Shop.Application.Products;
using Shop.Application.ProductsAdmin;
using Shop.Application.StockAdmin;
using Shop.Database;
using System.Threading.Tasks;

namespace Shop.UI.Controllers
{
    [Route("Admin")]
    public class DataController : Controller
    {
        private ApplicationDbContext _ctx;

        public DataController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet("productsGet")]
        public IActionResult GetProducts() => Ok(new Application.ProductsAdmin.GetProducts(_ctx).Do());
        [HttpPost("products/{Id}")]
        public IActionResult GetProduct(int id) => Ok(new Application.ProductsAdmin.GetProduct(_ctx).Do(id));
        [HttpPost("productsCreate")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProduct.Request request) => Ok((await new CreateProduct(_ctx).Do(request)));
        [HttpDelete("productss/{Id}")]
        public async Task<IActionResult> DeleteProduct(int id) => Ok((await new DeleteProduct(_ctx).Do(id)));
        [HttpPost("productsUpdate")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProduct.Request request) => Ok(await new UpdateProduct(_ctx).Do(request));



        [HttpGet("stocksGet")]
        public IActionResult GetStock() => Ok(new GetStock(_ctx).Do());
      
        [HttpPost("stocksCreate")]
        public async Task<IActionResult> CreateStock([FromBody] CreateStock.Request request) => Ok((await new CreateStock(_ctx).Do(request)));
        [HttpDelete("stocks/{Id}")]
        public async Task<IActionResult> DeleteStock(int id) => Ok((await new DeleteStock(_ctx).Do(id)));
        [HttpPut("stocksUpdate")]
        public async Task<IActionResult> UpdateStock([FromBody] UpdateStock.Request request) => Ok(await new UpdateStock(_ctx).Do(request));
    }
}
