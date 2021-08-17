using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class EncroachmentLogic
    {
        private EncroachmentDTO _encroachment = new EncroachmentDTO();

        public EncroachmentLogic(EncroachmentDTO encroachmentDTO)
        {
            _encroachment = encroachmentDTO;
        }

        public bool SaveEncroachment()
        {
            Encroachment encroachment = new Encroachment();

            encroachment.Encroachment_ID = _encroachment.EncroachmentID;
            encroachment.Estate_ID = _encroachment.EstateID;
            encroachment.Property_ID = _encroachment.PropertyID;
            encroachment.Name_Of_User = _encroachment.NameOfTheUser;
            encroachment.Address_ID = _encroachment.AddressID;
            encroachment.Telephone_Number = _encroachment.TelephoneNumber;
            encroachment.Size = _encroachment.TelephoneNumber;
            encroachment.Size = _encroachment.Size;
            encroachment.Started_Date = _encroachment.StartedDate;
            encroachment.Remarks = _encroachment.Remarks;
            encroachment.System_User_ID = _encroachment.SystemUserID;
            encroachment.Entry_Date = _encroachment.EntryDate;

            try
            {
                DataAccess.db.Encroachments.InsertOnSubmit(encroachment);
                DataAccess.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }

        }
    }
}
