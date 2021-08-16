﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class LeaseLogic
    {
        private LeaseDTO _lease = new LeaseDTO();
        public LeaseLogic(LeaseDTO leaseDTO)
        {
            _lease = leaseDTO;
        }

        public bool SaveLease()
        {
            Lease lease = new Lease();

            lease.Lease_ID = _lease.LeaseId;
            lease.Estate_ID = _lease.EstateId;
            lease.Property_ID = _lease.PropertyId;
            lease.Type_Of_Lease = _lease.TypeOfLease;
            lease.Rental_Value = _lease.RentalValue;
            lease.Lease_Status = _lease.LeaseStatus;
            lease.System_User_ID = _lease.SystemUserId;
            lease.Entry_Date = _lease.EntryDate;

            try
            {
                DataAccess.db.Leases.InsertOnSubmit(lease);
                DataAccess.SaveChangesToTheDB();
                return true;
            }
            catch { return true; }
        }
    }
}
