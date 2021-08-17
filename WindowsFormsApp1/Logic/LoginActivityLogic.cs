using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class LoginActivityLogic
    {
        private LoginActivityDTO _loginActivity = new LoginActivityDTO();

        public LoginActivityLogic(LoginActivityDTO loginActivityDTO)
        {
            _loginActivity = loginActivityDTO;
        }

        public bool SaveLoginActivity()
        {
            Login_Activity loginActivity = new Login_Activity();

            loginActivity.Login_Activity_ID = _loginActivity.LoginActivityID;
            loginActivity.Login_Time = _loginActivity.LoginTime;
            loginActivity.Attempt = _loginActivity.Attempt;
            loginActivity.Mac_Address = _loginActivity.MacAddress;
            loginActivity.System_User_ID = _loginActivity.SystemUserID;
            loginActivity.Logout_Time = _loginActivity.LogoutTime;

            try
            {
                DataAccess.db.Login_Activities.InsertOnSubmit(loginActivity);
                DataAccess.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }
        }
    }
}
