using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBeagle.Models
{
    public class Zivotinja 
    {
        public int id {  get; set; }
        public string ime { get; set; }
        //atibut za vrstu
        public bool udomljena {  get; set; }
        public DateTime datumRodjenja {  get; set; }
        public DateTime datumDolaska { get; set; }
        public DateTime datumUdomljenja { get; set; }
        public string oibUdomitelj {  get; set; }
    }
}
