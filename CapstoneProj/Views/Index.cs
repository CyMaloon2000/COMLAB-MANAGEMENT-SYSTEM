using System;
using CapstoneProj.Model;
using CapstoneProj.Model.dbEntity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneProj.Views;
using MetroFramework;
using MetroFramework.Forms;

namespace CapstoneProj
{
    public partial class Index : Form
    {
        int adminId;
        UnitOfWork work = new UnitOfWork();
        public Index(int id)
        {
            InitializeComponent();
            adminId = id;
        }

        public Index()
        {
        }

        private void Index_Load(object sender, EventArgs e)
        {
            Admin admin = work.AdminRepository.GetOne(filter: q => q.AdminId == adminId);
            lblUser.Text = $"USER: {admin.Username}";
            Dashboard openDashboard = new Dashboard();
            openDashboard.TopLevel = false;
            pnlContent.Controls.Add(openDashboard);
            openDashboard.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ManageStudent studentForm = new ManageStudent();
            studentForm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ManageAdmin adminForm = new ManageAdmin();
            adminForm.Show();
        }

        private void btnTerm_Click(object sender, EventArgs e)
        {
            ManageTerm termForm = new ManageTerm();
            termForm.Show();
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            ManageLaboratory labForm = new ManageLaboratory();
            labForm.Show();
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            ManageComputer computerForm = new ManageComputer();
            computerForm.Show();
        }

        private void btnSitIn_Click(object sender, EventArgs e)
        {
            ManageSitIn manageSitIn = new ManageSitIn();
            manageSitIn.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
