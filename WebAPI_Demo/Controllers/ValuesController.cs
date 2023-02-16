using Newtonsoft.Json;
using RestSharp;
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

        public List<StudentViewsModel> GetListProduct()
        {
            var list = new List<StudentViewsModel>();

            var list_std = DB.DataAccess.SqlDbHelper.GetStudents();
            if (list_std != null && list_std.Count > 0)
            {
                foreach (var item in list_std)
                {
                    list.Add(new StudentViewsModel
                    {
                        id = item.id
                        ,
                        StudentName = item.StudentName
                        ,
                        StudentAddress = item.StudentAddress
                        ,
                        StudentCode = item.StudentCode
                    });
                }
            }
            return list;
        }


        public ApiResponseModels GetListUser(int userId)
        {
            var model = new ApiResponseModels();
            var url = "https://reqres.in/api/users?page="+ userId;
            var client = new RestClient(url);
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("postman-token", "4600c295-6f26-bddb-de64-17bbe717838d");
            request.AddHeader("cache-control", "no-cache");
            var response = client.Execute(request);
            if (response == null || string.IsNullOrEmpty(response.Content))
            {
                model.support.text = "data not found";
                return model;
            }

            model = JsonConvert.DeserializeObject<ApiResponseModels>(response.Content);

            return model;
            
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
