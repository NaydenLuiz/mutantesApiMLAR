using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlnMutantesAPI.Models
{
    public class ADN
    {
        public string Id { get; set; }
        public DateTime DateTime { get; set; }
        public bool Multant { get; set; }
        public bool Human { get; set; } 
        public string DNA { get; set; }
    }
}
