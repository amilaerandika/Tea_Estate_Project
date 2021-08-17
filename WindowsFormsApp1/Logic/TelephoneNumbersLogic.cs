﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class TelephoneNumbersLogic
    {
        private TelephoneNumberDTO _telephoneNumber = new TelephoneNumberDTO();

        public TelephoneNumbersLogic(TelephoneNumberDTO telephoneNumberDTO)
        {
            _telephoneNumber = telephoneNumberDTO;
        }

        public bool SaveTelephoneNumbers()
        {
            Telephone_Number telephone_Number = new Telephone_Number();

            telephone_Number.Telephone_Number_ID = _telephoneNumber.TelephoneNumberID;
            telephone_Number.From_Table = _telephoneNumber.FromTable;
            telephone_Number.Primary_Key_From = _telephoneNumber.PrimaryKeyFrom;
            telephone_Number.Telephone_Number1 = _telephoneNumber.TelephoneNumberFeild;

            try
            {
                DataAccess.db.Telephone_Numbers.InsertOnSubmit(telephone_Number);
                DataAccess.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }
        }
    }
}
