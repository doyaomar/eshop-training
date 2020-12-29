using Catalog.API.Handlers;
using Catalog.API.Models;

using Microsoft.AspNetCore.Mvc;

using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogHandler _catalogHandler;

        public CatalogController(ICatalogHandler catalogHandler)
        {
            _catalogHandler = catalogHandler;
        }

        // POST api/<CatalogController>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateProductAsync([FromBody] CatalogItem catalogItem)
        {
            if (catalogItem is null)
            {
                return BadRequest();
            }

            await _catalogHandler.CreateProductAsync(catalogItem);

            return CreatedAtAction("", new { id = catalogItem.Id }, null);
        }

        // GET: api/<CatalogController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<CatalogController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // PUT api/<CatalogController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<CatalogController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}