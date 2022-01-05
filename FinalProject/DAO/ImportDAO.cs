using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    class ImportDAO
    {
        private static ImportDAO instance;

        public static ImportDAO Instance
        {
            get { if (instance == null) instance = new ImportDAO(); return ImportDAO.instance; }
            private set { ImportDAO.instance = value; }
        }
        private ImportDAO() { }

        public int GetUncheckImportIDByAddID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.[IMPORT] WHERE IDADDIMPORT = " + id );

            if (data.Rows.Count > 0)
            {
                Import import = new Import(data.Rows[0]);
                return import.ID;
            }

            return -1;
        }
    }
}
