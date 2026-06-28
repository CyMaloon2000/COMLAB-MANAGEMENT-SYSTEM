using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneProj.Model.dbEntity;
using CapstoneProj.Model;

namespace CapstoneProj.Views
{
    public partial class ManageLaboratory : Form
    {
        public ManageLaboratory()
        {
            InitializeComponent();
        }
        UnitOfWork work = new UnitOfWork();

        public class ViewDetail
        {
            public int LaboratoryId { get; set; }
            public string LaboratoryName { get; set; }
            public string LaboratoryCode { get; set; }
            public bool? IsActive { get; set; }
        }

        public void loadData()
        {
            List<Laboratory> labList = work.LaboratoryRepository.GetList();


            List<ViewDetail> source = new List<ViewDetail>();

            foreach (var item in labList)
            {
                ViewDetail tData = new ViewDetail
                {
                    LaboratoryId = item.LaboratoryId,
                    LaboratoryName = item.LaboratoryName,
                    LaboratoryCode = item.LaboratoryCode,
                    IsActive = (bool)item.IsActive
                };

                source.Add(tData);
            }
            dgvLaboratory.DataSource = source;
            clearFields();
        }

        public void clearFields()
        {
            txtLaboratoryId.Text = "";
            txtName.Text = "";
            txtLabCode.Text = "";
            

            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnCreateUpdate.Text = "Create";
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnCreateUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue this action?", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    if (txtLabCode.Text == "" || txtName.Text == "" || txtCompCount.Text == "" || cmbActive.Text == "")
                    {
                        MessageBox.Show("Please Fill up all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtLaboratoryId.Text != "")
                        {
                            int labId = Convert.ToInt32(txtLaboratoryId.Text);
                            Laboratory defaultLab = work.LaboratoryRepository.GetOne(filter: q => q.LaboratoryId == labId);
                            var status = cmbActive.SelectedIndex == 0 ? true : false;
                            Laboratory lab = new Laboratory
                            {
                                LaboratoryName = txtName.Text,
                                LaboratoryCode = txtLabCode.Text,
                                IsActive = status
                            };
                            if (defaultLab != null)
                            {
                                lab.LaboratoryId = defaultLab.LaboratoryId;

                                work.LaboratoryRepository.Update(lab);
                                clearFields();
                            }
                        }
                        else
                        {

                            var status = cmbActive.SelectedIndex == 0 ? true : false;
                            Laboratory lab = new Laboratory
                            {
                                LaboratoryName = txtName.Text,
                                LaboratoryCode = txtLabCode.Text,
                                IsActive = status
                            };
                            work.LaboratoryRepository.Insert(lab);

                            for (int i = 0; i <= Convert.ToInt32(txtCompCount.Text); i++)
                            {
                                Computer computer = new Computer
                                {
                                    ComputerName = $"{lab.LaboratoryName}-{i}",
                                    ComputerCode = $"{lab.LaboratoryCode}-{i}",
                                    LaboratoryId = lab.LaboratoryId
                                };

                                work.ComputerRepository.Insert(computer);
                            }


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

        private void ManageLaboratory_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvLaboratory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int searchString = (int)dgvLaboratory.CurrentRow.Cells[0].Value;
            Laboratory laboratory = work.LaboratoryRepository.GetOne(q => q.LaboratoryId == searchString);

            txtLaboratoryId.Text = laboratory.LaboratoryId.ToString();
            txtName.Text = laboratory.LaboratoryName;
            txtLabCode.Text = laboratory.LaboratoryCode;

            btnCreateUpdate.Text = "Update";
            btnClear.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtLaboratoryId.Text);
                Laboratory laboratory = work.LaboratoryRepository.GetOne(filter: q => q.LaboratoryId == id);
                int laboratoryId = laboratory == null ? 0 : laboratory.LaboratoryId;
                work.LaboratoryRepository.Delete(laboratory.LaboratoryId);
                loadData();
            }
            catch (Exception x)
            {

                MessageBox.Show("Error Ecountered: " + x, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
