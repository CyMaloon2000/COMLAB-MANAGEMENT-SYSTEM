using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneProj.Model;
using CapstoneProj.Model.dbEntity;

namespace CapstoneProj.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        UnitOfWork work = new UnitOfWork();
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login();
            }
            
        }

        public void login()
        {
            Admin admin = work.AdminRepository.GetOne(filter: q => q.Username == txtUsername.Text && q.Password == txtPassword.Text);
            if (admin != null)
            {
                if ((bool)admin.IsActive)
                {
                    Index indexForm = new Index(admin.AdminId);
                    indexForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("This account is currently inactive, Please contact system administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username and Password does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
