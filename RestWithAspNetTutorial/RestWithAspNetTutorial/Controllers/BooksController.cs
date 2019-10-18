using Microsoft.AspNetCore.Mvc;
using RestWithAspNetTutorial.Model;
using RestWithAspNetTutorial.Business.Implementations;
using RestWithAspNetTutorial.Business;

namespace RestWithAspNetTutorial.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BooksController : Controller
    {
        private IBookBusiness _bookBusiness;

        public BooksController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(_bookBusiness.FindAll());
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _bookBusiness.FindById(id);

            if (book == null) return NotFound();

            return Ok(book);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Book book)
        {
            if (book == null) return BadRequest();

            var updatedBook = _bookBusiness.Update(book);
            if (updatedBook == null) return NoContent();

            return new ObjectResult(_bookBusiness.Update(book));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            if (book == null) return BadRequest();

            return new ObjectResult(_bookBusiness.Create(book));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }
    }
}
