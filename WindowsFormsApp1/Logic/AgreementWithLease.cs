using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class AgreementWithLease
    {
        private AgreementLeaseDTO _agreement = new AgreementLeaseDTO();
        Tea_Estate_ModelDataContext db;

        public AgreementWithLease(AgreementLeaseDTO agreement)
        {
            _agreement = agreement;
            db = new Tea_Estate_ModelDataContext();
        }

        public bool SaveAgreementWithLease()
        {
            Agreement_Lease agreement_Lease = new Agreement_Lease();
            agreement_Lease.Agreement_ID = _agreement.AgreementId;
            agreement_Lease.Leaser_ID = _agreement.LeaserId;
            agreement_Lease.Property_ID = _agreement.PropertyId;
            agreement_Lease.Estate_ID = _agreement.EstateId;
            agreement_Lease.Start_Date = _agreement.StartDate;
            agreement_Lease.End_Date = _agreement.EndDate;
            agreement_Lease.Duration = _agreement.Duration;
            agreement_Lease.Agreement_Value = _agreement.AgreementValue;
            agreement_Lease.System_User_ID = _agreement.SystemUserId;
            agreement_Lease.Entry_Date = DateTime.Now;

            try
            {
                db.Agreement_Leases.InsertOnSubmit(agreement_Lease);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
