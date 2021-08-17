using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class TelephoneNumberDTO
    {
        public Guid TelephoneNumberID { get; set; }
        public string PrimaryKeyFrom { get; set; }
        public string FromTable { get; set; }
        public string TelephoneNumberFeild { get; set; }
    }
}
