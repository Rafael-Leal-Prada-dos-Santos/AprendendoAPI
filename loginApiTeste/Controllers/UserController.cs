using loginApiTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace loginApiTeste.Controllers
{
    public class UserController : ApiController
    {
        List<User> users = new List<User>();
        public UserController() {
            users.Add(new User { Id = 1, Email = "teste@teste.teste", Password = "teste" });
        }
        // GET: api/User
        public List<User> Get()
        {            
            return users;
        }

        // GET: api/User/5
        public User Get(int id)
        {
            return users.Where( x => x.Id == id).FirstOrDefault();
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
