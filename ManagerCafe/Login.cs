﻿using ManagerCafe.DAO;
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
	public partial class flogin : Form
	{
		public flogin()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender,EventArgs e)
		{

		}

		private void label1_Click(object sender,EventArgs e)
		{

		}

		private void btnExit_Click(object sender,EventArgs e)
		{
			Application.Exit();
		}

		private void flogin_FormClosing(object sender,FormClosingEventArgs e)
		{
			if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
			{
				e.Cancel=true;
			}
		}

         bool login(string userName,string passWord)
        {
            var isCheck= AccountDAO.Instance.Login(userName, passWord);
            return isCheck;
        }

		private void btnLogin_Click(object sender,EventArgs e)
		{
            string userName = txbUsername.Text;
            string passWord = txbPass.Text;
            if(login(userName, passWord))
            {
                fTableManager fTableManager = new fTableManager();
                this.Hide();
                fTableManager.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu hoặc.! ");
            }	
		}
	}
}
