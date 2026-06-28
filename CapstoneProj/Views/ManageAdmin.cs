using CapstoneProj.Model;
using CapstoneProj.Model.dbEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProj.Views
{
    public partial class ManageAdmin : Form
    {
        public ManageAdmin()
        {
            InitializeComponent();
        }
        UnitOfWork work = new UnitOfWork();
        private void btnCreateUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue this action?", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    if (txtUsername.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || cmbGender.Text == "" || dtpBirthDate.Value == null || txtEmail.Text == "" || txtPassword.Text == "")
                    {
                        MessageBox.Show("Please Fill up all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int? adminId = 0;
                        if (txtAdminId.Text != "")
                        {
                            adminId = int.Parse(txtAdminId.Text);
                        }

                        Admin defaultAdmin = work.AdminRepository.GetOne(filter: q => q.AdminId == adminId);
                        Person person = new Person
                        {
                            Lastname = txtLastName.Text,
                            Firstname = txtFirstName.Text,
                            Middlename = txtMiddleName.Text,
                            GenderId = cmbGender.SelectedIndex == 0 ? 1 : 2,
                            Birthdate = Convert.ToDateTime(dtpBirthDate.Text),
                        };

                        if (defaultAdmin == null)
                        {
                            work.PersonRepository.Insert(person);

                            Admin admin = new Admin
                            {
                                Username = txtUsername.Text,
                                Password = txtPassword.Text,
                                PersonId = person.PersonId,
                                IsActive = true,
                            };
                            
                            work.AdminRepository.Insert(admin);
                            
                        }
                        else
                        {
                            person.PersonId = defaultAdmin.PersonId ?? 0;

                            work.PersonRepository.Update(person);
                            Admin admin = new Admin
                            {
                                Username = txtUsername.Text,
                                Password = txtPassword.Text,
                                PersonId = person.PersonId,
                                IsActive = true
                            };
                            admin.AdminId = defaultAdmin.AdminId;
                            work.AdminRepository.Update(admin);
                        }

                        loadData();
                    }


                }
                catch (Exception x)
                {

                    MessageBox.Show("Error Ecountered: " + x, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void loadData()
        {
            List<Admin> adminList = work.AdminRepository.GetList(includeProperties: "Person, Person.Gender");


            List<ViewDetail> source = new List<ViewDetail>();

            foreach (var item in adminList)
            {
                ViewDetail pData = new ViewDetail
                {
                    AdminId = item.AdminId,
                    Firstname = item.Person.Firstname,
                    Lastname = item.Person.Lastname,
                    Middlname = item.Person.Middlename,
                    UserName = item.Username
                };

                source.Add(pData);
            }
            dgvAdmin.DataSource = source;
            //DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            //buttonColumn.HeaderText = "Action";
            //buttonColumn.Text = "Click Me";
            //buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            //dgvAdmin.Columns.Add(buttonColumn);
            clearFields();
        }
        public class ViewDetail
        {
            public int AdminId { get; set; }
            public string UserName { get; set; }
            public string Lastname { get; set; }
            public string Firstname { get; set; }
            public string Middlname { get; set; }


        }
        public void clearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            cmbGender.SelectedIndex = 0;
            dtpBirthDate.Value = DateTime.Now;
            txtEmail.Text = "";

            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnCreateUpdate.Text = "Create";
        }

        private void dgvAdmin_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string searchString = dgvAdmin.CurrentRow.Cells[1].Value.ToString();
            Admin admin = work.AdminRepository.GetOne(q => q.Username == searchString);
            txtAdminId.Text = admin.AdminId.ToString();
            txtUsername.Text = admin.Username;
            txtPassword.Text = admin.Password;
            txtFirstName.Text = admin.Person.Firstname;
            txtLastName.Text = admin.Person.Lastname;
            txtMiddleName.Text = admin.Person.Middlename;
            cmbGender.SelectedIndex = (int)admin.Person.GenderId - 1;
            dtpBirthDate.Value = (DateTime)admin.Person.Birthdate;

            btnCreateUpdate.Text = "Update";
            btnClear.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Admin admin = work.AdminRepository.GetOne(filter: q => q.Username == txtUsername.Text);
                int personid = (int)admin.PersonId;
                work.AdminRepository.Delete(admin.AdminId);
                work.PersonRepository.Delete(personid);
                loadData();
            }
            catch (Exception x)
            {

                MessageBox.Show("Error Ecountered: " + x, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ManageAdmin_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
