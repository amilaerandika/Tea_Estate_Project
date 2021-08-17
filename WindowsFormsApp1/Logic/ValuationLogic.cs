using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class ValuationLogic
    {
        private ValuationDTO _valuation = new ValuationDTO();
        public ValuationLogic(ValuationDTO valuationDTO)
        {
            _valuation = valuationDTO;
        }

        public bool CreateValuation()
        {
            Valuation valuation = new Valuation();

            valuation.Valuation_ID = _valuation.ValuationId;
            valuation.Estate_ID = _valuation.EstateId;
            valuation.Property_ID = _valuation.PropertyId;
            valuation.Valuation_Date = _valuation.ValuationDate;
            valuation.Previous_Value = _valuation.PreviousValue;
            valuation.Amended_Value = _valuation.AmendedValue;
            valuation.Remarks = _valuation.Remarks;
            valuation.Document_ID = _valuation.DocumentId;
            valuation.System_User_ID = _valuation.SystemUserId;
            valuation.Entry_Date = _valuation.EntryDate;

            try
            {
                DataAccess.db.Valuations.InsertOnSubmit(valuation);
                DataAccess.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }
        }
    }
}
