using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class DocumentDTO
    {
		public Guid DocumentID { get; set; }
        public string FromTable { get; set; }
        public string DocumentType { get; set; }
        public string PrimaryKeyFromTable { get; set; }
        public string DocumentName { get; set; }
        public string FileLocation { get; set; }
        public string BackupLocation { get; set; }
        public string Remarks { get; set; }
        public Guid SystemUserId { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
