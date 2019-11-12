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
