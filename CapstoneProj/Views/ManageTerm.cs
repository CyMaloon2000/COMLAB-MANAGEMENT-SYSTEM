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
    public partial class ManageTerm : Form
    {
        public ManageTerm()
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
                    if (txtTermName.Text == "" || dtpDateFrom.Value == null || dtpDateFrom.Value == null)
                    {
                        MessageBox.Show("Please Fill up all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(txtTermId.Text != "")
                        {
                            int termId = Convert.ToInt32(txtTermId.Text);
                            Term defaultTerm = work.TermRepository.GetOne(filter: q => q.TermId == termId);
                            Term term = new Term
                            {
                                TermName = txtTermName.Text,
                                DateFrom = dtpDateFrom.Value,
                                DateTo = dtpDateTo.Value,
                                IsActive = rdbIsActive.Checked
                            };
                            if (defaultTerm != null)
                            {
                                term.TermId = defaultTerm.TermId;

                                work.TermRepository.Update(term);
                            }
                        }
                        else
                        {
                            Term term = new Term
                            {
                                TermName = txtTermName.Text,
                                DateFrom = dtpDateFrom.Value,
                                DateTo = dtpDateTo.Value,
                                IsActive = rdbIsActive.Checked
                            };
                            work.TermRepository.Insert(term);
                            
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

        public class ViewDetail
        {
            public int TermId { get; set; }
            public string TermName { get; set; }
            public DateTime? DateFrom { get; set; }
            public DateTime? DateTo { get; set; }
            public bool? IsActive { get; set; }
        }

        public void loadData()
        {
            List<Term> termList = work.TermRepository.GetList();


            List<ViewDetail> source = new List<ViewDetail>();

            foreach (var item in termList)
            {
                ViewDetail tData = new ViewDetail
                {
                    TermId = item.TermId,
                    TermName = item.TermName,
                    DateFrom = (DateTime)item.DateFrom,
                    DateTo = (DateTime)item.DateTo,
                    IsActive = (bool)item.IsActive
                };

                source.Add(tData);
            }
            dgvTerm.DataSource = source;
            dgvTerm.Refresh();
            clearFields();
        }

        public void clearFields()
        {
            txtTermName.Text = "";
            dtpDateFrom.Value = DateTime.Now;
            dtpDateTo.Value = DateTime.Now;
            rdbIsActive.Checked = false;

            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnCreateUpdate.Text = "Create";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dgvTerm_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int searchString = Convert.ToInt32(dgvTerm.CurrentRow.Cells[0].Value);
            Term term = work.TermRepository.GetOne(q => q.TermId == searchString);

            txtTermId.Text = term.TermId.ToString();
            txtTermName.Text = term.TermName;
            dtpDateFrom.Value = (DateTime)term.DateFrom;
            dtpDateTo.Value = (DateTime)term.DateTo;
            rdbIsActive.Checked = (bool)term.IsActive;

            btnCreateUpdate.Text = "Update";
            btnClear.Visible = true;
            btnDelete.Visible = true;
        }

        private void ManageTerm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int termId = Convert.ToInt32(txtTermId.Text);
                Term term = work.TermRepository.GetOne(filter: q => q.TermId == termId);
                work.TermRepository.Delete(term.TermId);
                loadData();
            }
            catch (Exception x)
            {

                MessageBox.Show("Error Ecountered: " + x, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
