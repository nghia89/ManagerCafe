using System.Data;

namespace ManagerCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "usp_login @userName , @passWord";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { userName, passWord });
            if (data.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
