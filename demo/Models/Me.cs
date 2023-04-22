using System;
using System.Collections.Generic;
using System.Text;

namespace demo.Models
{
    public class Me
    {
        public long MeId { get; set; }
        public string PhoneName { get; set; }
        public string Name {get; set;}
        public string ProfileImage { get; set; }
        public virtual Status Status { get; set; }
    }
}
