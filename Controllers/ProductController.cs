using System.Linq;
using System.Threading.Tasks;
using AngularNetStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularNetStore.Controllers
{


    [Route("api/Products")]

    public class ProductController : Controller
    {
        private readonly AplicationDbContext _db;

        public ProductController(AplicationDbContext db)
        {
            _db = db;
        }

        //Get: api/products

         [HttpGet()]
        public IActionResult GetProduts()
        {

            return Ok(_db.Products.ToList());
        }

        [HttpPost()]
        public async Task<IActionResult> AddProduct([FromBody] ProductModel formdata)
        {
            var newproduct = new ProductModel
            {
                Name = formdata.Name,
                ImageUrl = formdata.ImageUrl,
                Description = formdata.Description,
                OutOfStack = formdata.OutOfStack,
                Price = formdata.Price
            };

            await _db.Products.AddAsync(newproduct);

            await _db.SaveChangesAsync();

            return Ok(new JsonResult("The Product was Added Successfully"));
        }

        public void Post()
        {

        }

        public void Put()
        {

        }

        public void Delete()
        {

        }
    }
}