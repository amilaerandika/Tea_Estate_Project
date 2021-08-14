using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Logic
{
    public static class DataAccess
    {
        public static Tea_Estate_ModelDataContext db;

        public static void CreateDBConnection()
        {
            db = new Tea_Estate_ModelDataContext();
        }

        public static void SaveChangesToTheDB()
        {
            db.SubmitChanges();
        }
    }
}
