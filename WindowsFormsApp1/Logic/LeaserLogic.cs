using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class LeaserLogic
    {
        private LeaserDTO _leaser = new LeaserDTO();
        public LeaserLogic(LeaserDTO leaserDTO)
        {
            _leaser = leaserDTO;
        }

        public bool SaveLeaseContract()
        {
            Leaser leaser = new Leaser();

            leaser.Leaser_ID = _leaser.LeaserId;
            leaser.Name = _leaser.Name;
            leaser.Phone_Number_ID = _leaser.PhoneNumberId;
            leaser.Email = _leaser.Email;
            leaser.Address_ID = _leaser.AddressId;
            leaser.System_User_ID = _leaser.SystemUserId;
            leaser.Entry_Date = _leaser.EntryDate;

            try
            {
                DataAccess.db.Leasers.InsertOnSubmit(leaser);
                DataAccess.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }
        }
    }
}
