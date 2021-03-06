﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirebaseAuth.Model;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;

namespace FirebaseAuth.Api.Controllers
{

    public class UsersController : ApiController
    {
        // GET api/users
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/users/5
        public string Get(string id)
        {
            //HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");
            //response.Content = new StringContent("hello", Encoding.Unicode);
            return id;
        }

        // POST api/users
        public void Post([FromBody]FbUser user)
        {
            // Save user
        }

        // PUT api/users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/users/5
        public void Delete(int id)
        {
        }
    }
}
