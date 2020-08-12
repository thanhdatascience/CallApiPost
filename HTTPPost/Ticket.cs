using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HTTPPost
{
    public class Ticket
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }
        public string ContactCompanyName { get; set; }
        public Tag Tags { get; set; }
        public Attribute Attributes { get; set; }
    }
}
