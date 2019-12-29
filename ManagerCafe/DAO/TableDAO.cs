using ManagerCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCafe.DAO
{
   public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get {
                if (instance == null)
                    instance = new TableDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tables = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("usp_getTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table =  Table.From(item);
                tables.Add(table);
            }
            return tables;
        }
    }
}
