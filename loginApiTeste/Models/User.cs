using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace loginApiTeste.Models
{
    public class User
    {
        public int Id { get; set; } = 0;
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
    }
}