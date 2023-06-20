using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanlamaYönetim.Entities
{
    public class User
    {
        public User()
        {
            Events = new List<Event>();
        }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string TCNo { get; set; }
        public string UserTel { get; set; }
        public string UserEmail { get; set; }
        public string UserAddress { get; set; }
        public string UserType { get; set; }
        public List<Event>  Events { get; set; }
    }
}
