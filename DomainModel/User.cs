using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class User
    {
        public User()
        {
            SexType = new Sex();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSubName { get; set; }

        public string UserMail { get; set; }

        public string UserPass { get; set; }
        public DateTime BornDate { get; set; }
        public Sex SexType { get; set; }
        public string Country { get; set; }
    }
}
