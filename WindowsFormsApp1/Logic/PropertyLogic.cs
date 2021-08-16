using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class PropertyLogic
    {
        private PropertyDTO _property = new PropertyDTO();

        public PropertyLogic(PropertyDTO propertyDTO)
        {
            _property = propertyDTO;
        }

        public bool SaveProperty()
        {
            Property property = new Property();

            property.Property_ID = _property.PropertyId;
            property.Estate_ID = _property.EstateId;
            property.Property_Type = _property.PropertyType;
            property.Size = _property.Size;
            property.Plan_Number = _property.PlanNumber;
            property.Valuation = _property.Valuation;
            property.Current_Value = _property.CurrentValue;
            property.System_User_ID = _property.SystemUserId;
            property.Entry_Date = _property.EntryDate;

            try
            {
                DataAccess.db.Properties.InsertOnSubmit(property);
                DataAccess.SaveChangesToTheDB();
                return true;
            }
            catch { return false; }
        }
    }
}
