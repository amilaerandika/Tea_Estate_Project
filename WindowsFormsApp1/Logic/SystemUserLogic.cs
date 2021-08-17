using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class SystemUserLogic
    {
        private SystemUserDTO _systemUser;
        public SystemUserLogic()
        {
            _systemUser = new SystemUserDTO();
        }

        public SystemUserDTO GetSystemUser(string userName, string password)
        {
            var user = DataAccess.db.System_Users.Where(s => s.System_User_Name == userName && s.Password == password).First();

            if (user != null)
            {
                _systemUser.SystemUserId = user.System_User_ID;
                _systemUser.SystemUserName = user.System_User_Name;
                _systemUser.FullName = user.Full_Name;
                _systemUser.EmailAddress = user.Email_Address;

                return _systemUser;
            }

            else return null;
        }
    }
}
