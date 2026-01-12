using API_with_EntitiyFramework.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_with_EntitiyFramework.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        //ORM - Object-Relational Mapping (objektum <->relációs adatbázis)
        //EntityFramework - Visual Studio beépített ORM-je
        //C# -> adatbázis tábla
        //Objektum -> egy rekord(sor) a táblában

        private readonly ShopDbContext _context;
        public ProductAPIController(ShopDbContext context)
        {
                _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        //ID alapján egy terméket visszaadni
        [HttpGet]
        public IActionResult GetOnById(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();//404 error, ha nincs ilyen
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Product product) 
        { 
            _context.Products.Add(product);
            // FONTOS!! Módosításokat menteni kell!
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAll), product);
        }

        //PUT műveletet kell elvégezni
        //[HttpPut("{id}")]
        [HttpPut]
        public IActionResult Update(int id,Product modositott) 
        {
           var modositando=_context.Products.Find(id);
           if (modositando == null) return NotFound();

           modositando.Name = modositott.Name;
           modositando.Price = modositott.Price;
           modositando.ExperationData=modositott.ExperationData;

            _context.SaveChanges();
            return Ok(modositando);
        }

        //DELETE - törlés művelet
        [HttpDelete]
        public IActionResult Delete(int id) 
        { 
            var torlendo = _context.Products.Find(id);
            if(torlendo == null) return NotFound();
            _context.Products.Remove(torlendo);

            _context.SaveChanges();

            return NoContent();
        }


    }
}
