using ManagerCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCafe
{
	public partial class fAdmin : Form
	{
		public fAdmin()
		{
			InitializeComponent();
            LoadAcount();
		}
        void LoadAcount()
        {
            string query = "exec usp_GetByUserName @userName";
            var objectParam = new Object[] { "K9","Staff" };
            dtgvAcount.DataSource = DataProvider.Instance.ExecuteQuery(query, objectParam);
        }


		private void label1_Click(object sender,EventArgs e)
		{

		}

		private void tcAdmin_SelectedIndexChanged(object sender,EventArgs e)
		{

		}

		private void panel4_Paint(object sender,PaintEventArgs e)
		{

		}

		private void tcFood_Click(object sender,EventArgs e)
		{

		}

		private void panel6_Paint(object sender,PaintEventArgs e)
		{

		}

		private void cbTableStatus_Click(object sender,EventArgs e)
		{

		}
	}
}
