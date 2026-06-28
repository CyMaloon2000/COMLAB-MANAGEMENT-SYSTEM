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
    public partial class ManageComputer : Form
    {
        public ManageComputer()
        {
            InitializeComponent();
        }
        UnitOfWork work = new UnitOfWork();

        public class ViewDetail
        {
            public int ComputerId { get; set; }
            public string ComputerName { get; set; }
            public string ComputerCode { get; set; }
            public string Laboratory { get; set; }
            public bool? IsActive { get; set; }
        }

        public void loadData()
        {
            List<Computer> computerList = work.ComputerRepository.GetList(includeProperties:"Laboratory");


            List<ViewDetail> source = new List<ViewDetail>();

            foreach (var item in computerList)
            {
                ViewDetail tData = new ViewDetail
                {
                    ComputerId = item.ComputerId,
                    ComputerName = item.ComputerName,
                    ComputerCode = item.ComputerCode,
                    Laboratory = item.Laboratory.LaboratoryName,
                    IsActive = (bool)item.IsActive
                };

                source.Add(tData);
            }
            dgvComputer.DataSource = source;
            clearFields();
        }

        public void clearFields()
        {
            txtComputerId.Text = "";
            txtComputerName.Text = "";
            txtComputerCode.Text = "";
            rdbIsActive.Checked = false;

            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnCreateUpdate.Text = "Create";
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ManageComputer_Load(object sender, EventArgs e)
        {
            loadData();

            cmbLaboratory.DataSource = work.LaboratoryRepository.GetList();
            cmbLaboratory.ValueMember = "LaboratoryId";
            cmbLaboratory.DisplayMember = "LaboratoryName";
        }

        private void cmbLaboratory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int computerCount = work.ComputerRepository.GetList(q => q.Laboratory.LaboratoryName == cmbLaboratory.Text,includeProperties:"Laboratory").Count();
            computerCount++;
            Laboratory lab = work.LaboratoryRepository.GetOne(q => q.LaboratoryName == cmbLaboratory.Text);
            if(lab != null)
            {
                txtComputerName.Text = $"Computer-{computerCount}";
                txtComputerCode.Text = $"{lab.LaboratoryCode}-{computerCount}";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnCreateUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue this action?", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    if (txtComputerCode.Text == "" || txtComputerName.Text == "")
                    {
                        MessageBox.Show("Please Fill up all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtComputerId.Text != "")
                        {
                            int compId = Convert.ToInt32(txtComputerId.Text);
                            Laboratory defaultLab = work.LaboratoryRepository.GetOne(q => q.LaboratoryName == cmbLaboratory.Text);
                            Computer defaultComputer = work.ComputerRepository.GetOne(filter: q => q.ComputerId == compId);
                            Computer computer = new Computer
                            {
                                ComputerName = txtComputerName.Text,
                                ComputerCode = txtComputerCode.Text,
                                LaboratoryId = defaultLab.LaboratoryId,
                                IsActive = rdbIsActive.Checked
                            };

                            if (defaultComputer != null)
                            {
                                computer.ComputerId = defaultComputer.ComputerId;

                                work.ComputerRepository.Update(computer);
                                computer.Laboratory = defaultLab;
                                clearFields();
                            }
                        }
                        else
                        {
                            Laboratory defaultLab = work.LaboratoryRepository.GetOne(q => q.LaboratoryName == cmbLaboratory.Text);
                            Computer computer = new Computer
                            {
                                ComputerName = txtComputerName.Text,
                                ComputerCode = txtComputerCode.Text,
                                LaboratoryId = defaultLab.LaboratoryId,
                                IsActive = rdbIsActive.Checked
                            };

                            work.ComputerRepository.Insert(computer);
                            
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

        private void dgvComputer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int searchString = (int)dgvComputer.CurrentRow.Cells[0].Value;
            Computer computer = work.ComputerRepository.GetOne(q => q.ComputerId == searchString);

            txtComputerId.Text = computer.ComputerId.ToString();
            txtComputerName.Text = computer.ComputerName;
            txtComputerCode.Text = computer.ComputerCode;

            btnCreateUpdate.Text = "Update";
            btnClear.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtComputerId.Text);
                Computer computer = work.ComputerRepository.GetOne(filter: q => q.ComputerId == id);
                int computerId = computer == null ? 0 : computer.ComputerId;
                work.ComputerRepository.Delete(computer.ComputerId);
                loadData();
            }
            catch (Exception x)
            {

                MessageBox.Show("Error Ecountered: " + x, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
