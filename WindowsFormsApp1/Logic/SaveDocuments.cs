using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Logic
{
    public class SaveDocuments
    {
        private DocumentDTO _documents = new DocumentDTO();

        public SaveDocuments(DocumentDTO documentDTO)
        {
            _documents = documentDTO;
        }

        public bool SaveDocumentsToFoldor()
        {
            return false;
        }

        public Guid SaveDocumentToDB()
        {
            try
            {
                Document document = new Document();

                document.Document_ID = _documents.DocumentID;
                document.From_Table = _documents.FromTable;
                document.Document_Type = _documents.DocumentType;
                document.Primary_Key = _documents.PrimaryKeyFromTable;
                document.Document_Name = _documents.DocumentName;
                document.File_Location = _documents.FileLocation;
                document.Backup_Location = _documents.BackupLocation;
                document.Remarks = _documents.Remarks;
                document.System_User_ID = _documents.SystemUserId;
                document.Entry_Date = _documents.EntryDate;


                DataAccess.db.Documents.InsertOnSubmit(document);
                DataAccess.SaveChangesToTheDB();

                return _documents.DocumentID;
            }
            catch { return Guid.Empty; }
        }
    }
}
