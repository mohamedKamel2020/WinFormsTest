using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; } = null;
        public string ImageName { get; set; } = null;
        public string Notes { get; set; }
       //public IFormFile Image { get; set; }
    }
}
