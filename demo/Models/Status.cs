using System;
using System.Collections.Generic;
using System.Text;

namespace demo.Models
{
    public class Status
    {
        public long StatusID { get; set; }
        public Contact Contact { get; set; }
        public List<string> Images { get; set; }
        public string Description { get; set; }
        public string Pushdate { get; set; }
        public string Image { get; internal set; }
    }
}
