using ManagerCafe.DAO;
using ManagerCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCafe
{
	public partial class fTableManager : Form
	{
		public fTableManager()
		{
			InitializeComponent();
            LoadTable();

        }

        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() {Width=TableDAO.TableWidth, Height=TableDAO.TableHeight};
                btn.Text = item.Name +'\n'+item.Status;
                if (item.Status=="Trống")
                {
                    btn.BackColor = Color.Red;
                }
                else
                {

                    btn.BackColor = Color.Blue;
                }
                flpTable.Controls.Add(btn);
            }

        }

		private void đăngXuấtToolStripMenuItem_Click(object sender,EventArgs e)
		{

		}

		private void thôngTinCáNhânToolStripMenuItem_Click(object sender,EventArgs e)
		{
			fAccountProFile fAccountProFile = new fAccountProFile();
			fAccountProFile.ShowDialog();
		}

		private void adminToolStripMenuItem_Click(object sender,EventArgs e)
		{
			fAdmin fAdmin = new fAdmin();
			fAdmin.ShowDialog();
		}
	}
}
