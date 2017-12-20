using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbageCollectorLesson
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        ~User() { }
        public User()
        {

        }
    }
}
