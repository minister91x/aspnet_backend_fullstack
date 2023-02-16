using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Demo.Models;

namespace WebAPI_Demo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public List<ProductViewsModels> GetListProduct()
        {
            var list = new List<ProductViewsModels>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new ProductViewsModels { ProductId=i,ProductName="Sản phẩm "+ i, SupplierName="Web Thầy Quân"});
            }
            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
