using System.Web.Http.Cors;
using News.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace News.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Product> Get()
            {
                var products = new List<Product>(){
                    new Product(){
                    productId = 1,
                    productName = "Samsung Note 5",
                    productCode = "ss2014",
                    releaseDate = "23/6/2015",
                    starRating = 4.5,
                    price = 450,
                    description = "Made in VietName",
                    imageUrl = "https://cdn3.tgdd.vn/Products/Images/42/72373/samsung-galaxy-note-5-14-200x200.jpg"
                },
                 new Product(){
                    productId = 1,
                    productName = "Samsung Note 7",
                    productCode = "ss2016",
                    releaseDate = "23/6/2016",
                    starRating = 4.5,
                    price = 650,
                    description = "Made in VietName",
                    imageUrl = "https://cdn3.tgdd.vn/Products/Images/42/72373/samsung-galaxy-note-5-14-200x200.jpg"
                }
            };

            return products;
            }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
