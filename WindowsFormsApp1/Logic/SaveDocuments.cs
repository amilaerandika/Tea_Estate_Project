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
                _documents.DocumentID = Guid.NewGuid();

                Document document = new Document();

                document.Document_ID = _documents.DocumentID;
                document.From_Table = _documents.FromTable;


                DataAccess.CreateDBConnection();
                DataAccess.db.Documents.InsertOnSubmit(document);

                return _documents.DocumentID;
            }
            catch { return Guid.Empty; }
    }
}
