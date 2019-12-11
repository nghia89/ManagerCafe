using System.Data;
using System.Data.SqlClient;

namespace ManagerCafe.DAO
{
    public class DataProvider
    {
        public string connectStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;User ID=sa;Password=123";

        public DataTable ExecuteQuery(string query,object[] param=null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (param != null)
                {
                    int i = 0;
                    string[] listParam = query.Split(' ');
                    foreach (var item in listParam)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                connection.Close();
            }


            return dataTable;
        }
        public int ExecuteNoneQuery(string query, object[] param = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (param != null)
                {
                    int i = 0;
                    string[] listParam = query.Split(' ');
                    foreach (var item in listParam)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }


            return data;
        }

        public object ExecuteScalar(string query, object[] param = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectStr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (param != null)
                {
                    int i = 0;
                    string[] listParam = query.Split(' ');
                    foreach (var item in listParam)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }


            return data;
        }
    }
}
