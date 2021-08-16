using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class DuePaymentLogic
    {
        private DuePaymentDTO _duePaymentDTO = new DuePaymentDTO();
        public DuePaymentLogic(DuePaymentDTO duePayments)
        {
            _duePaymentDTO = duePayments;
        }

        public bool SaveDuePayment()
        {
            Due_Payment due_Payment = new Due_Payment();

            due_Payment.Due_Payment_ID = _duePaymentDTO.DuePaymentId;
            due_Payment.Due_Date = _duePaymentDTO.DueDate;
            due_Payment.Property_ID = _duePaymentDTO.PropertyId;
            due_Payment.Estate_ID = _duePaymentDTO.EstateId;
            due_Payment.Agreement_ID = _duePaymentDTO.AgreementId;
            due_Payment.Estate_Name = _duePaymentDTO.EstateName;
            due_Payment.Due_Value = _duePaymentDTO.DueValue;
            due_Payment.Leaser_ID = _duePaymentDTO.LeaserId;
            due_Payment.Payout_Status = _duePaymentDTO.PayoutStatus;
            due_Payment.Entry_Date = _duePaymentDTO.EntryDate;
            due_Payment.System_User_ID = _duePaymentDTO.SystemUserId;

            try
            {
                DataAccess.db.Due_Payments.InsertOnSubmit(due_Payment);
                DataAccess.SaveChangesToTheDB();

                return true;
            }
            catch { return false; }
        }
    }
}
