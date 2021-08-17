using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class LoginActivityDTO
    {
        public Guid LoginActivityID { get; set; }
        public DateTime LoginTime { get; set; }
        public int Attempt { get; set; }
        public string MacAddress { get; set; }
        public Guid SystemUserID { get; set; }
        public DateTime LogoutTime { get; set; }
    }
}
