using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanlamaYönetim.Entities
{
    public class Event
    {
        public int EventID { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventBeginTime { get; set; }
        public DateTime EventIdentify { get; set; }
        public string EventDescription { get; set; }
        public User User { get; set; }
    }
}
