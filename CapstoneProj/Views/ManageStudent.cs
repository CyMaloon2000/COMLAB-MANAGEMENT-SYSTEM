using CapstoneProj.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using CapstoneProj.Model.dbEntity;
using System.Threading;
using System.IO;
using ExcelDataReader;
using System.Runtime.InteropServices.ComTypes;

namespace CapstoneProj.Views
{
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }
        UnitOfWork work = new UnitOfWork();
        DataTableCollection tableCollections;
        private void btnIndex_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            loadData();

            cmbCourse.DataSource = work.ProgramCourseRepository.GetList();
            cmbCourse.ValueMember = "ProgramCourseId";
            cmbCourse.DisplayMember = "ProgramCourseCode";
        }
        public void loadData()
        {
            Thread.Sleep(300);

            List<Student> personList = work.StudentRepository.GetList(includeProperties: "Person, Person.Gender");


            List<ViewDetail> source = new List<ViewDetail>();

            foreach (var item in personList)
            {
                ViewDetail pData = new ViewDetail
                {
                    Firstname = item.Person.Firstname,
                    Lastname = item.Person.Lastname,
                    Middlname = item.Person.Middlename,
                    StudentNo = item.StudentNo
                };

                source.Add(pData);
            }
            dgvStudent.DataSource = source;
            clearFields();
        }
        public class ViewDetail
        {
            public string StudentNo { get; set; }
            public string Lastname { get; set; }
            public string Firstname { get; set; }
            public string Middlname { get; set; }
        }

        private void dgvStudent_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string searchString = dgvStudent.CurrentRow.Cells[0].Value.ToString();
            Student student = work.StudentRepository.GetOne(q => q.StudentNo == searchString);

            txtStudentNo.Text = student.StudentNo;
            txtFirstName.Text = student.Person.Firstname;
            txtLastName.Text = student.Person.Lastname;
            txtMiddleName.Text = student.Person.Middlename;
            cmbGender.SelectedIndex = (int)student.Person.GenderId - 1;
            dtpBirthDate.Value = (DateTime)student.Person.Birthdate;
            cmbCourse.SelectedValue = student.ProgramCourseId;

            btnCreateUpdate.Text = "Update";
            btnClear.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnCreateUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue this action?", "Add Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    if (txtStudentNo.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || cmbGender.Text == "" || dtpBirthDate.Value == null)
                    {
                        MessageBox.Show("Please Fill up all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Student defaultStudent = work.StudentRepository.GetOne(filter: q => q.StudentNo == txtStudentNo.Text);
                        Person person = new Person
                        {
                            Lastname = txtLastName.Text,
                            Firstname = txtFirstName.Text,
                            Middlename = txtMiddleName.Text,
                            GenderId = cmbGender.SelectedIndex == 0 ? 1 : 2,
                            Birthdate = Convert.ToDateTime(dtpBirthDate.Text),
                        };

                        if (defaultStudent == null)
                        {
                            work.PersonRepository.Insert(person);

                            Student student = new Student
                            {
                                StudentNo = txtStudentNo.Text,
                                PersonId = person.PersonId,
                                ProgramCourseId = Convert.ToInt32(cmbCourse.SelectedValue)
                            };

                            work.StudentRepository.Insert(student);
                        }
                        else
                        {
                            person.PersonId = defaultStudent.PersonId ?? 0;
                            work.PersonRepository.Update(person);
                            Student student = new Student
                            {
                                StudentId = defaultStudent.StudentId,
                                StudentNo = txtStudentNo.Text,
                                ProgramCourseId = Convert.ToInt32(cmbCourse.SelectedValue),
                                PersonId = person.PersonId
                            };

                            work.StudentRepository.Update(student);
                        }
                    }

                    loadData();
                }
                catch (Exception x)
                {

                    MessageBox.Show("Error Ecountered: " + x, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = work.StudentRepository.GetOne(filter: q => q.StudentNo == txtStudentNo.Text);
                int personid = student.PersonId ?? 0;
                work.StudentRepository.Delete(student.StudentId);
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
        public void clearFields()
        {
            txtStudentNo.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleName.Text = "";
            cmbGender.SelectedIndex = 0;
            dtpBirthDate.Value = DateTime.Now;

            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnCreateUpdate.Text = "Create";
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter="Excel 9702993 Workbook|*.xls|Excel Workbook|*.xlsx"})
            {
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Open(openFile.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() {UseHeaderRow = true}
                            });
                            tableCollections = result.Tables;
                            stream.Close();
                        }
                    }

                    DataTable dt = tableCollections["Student"];

                    if(dt != null)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Student student = new Student();
                            student.StudentNo = dt.Rows[i]["StudentNo"].ToString();

                            List<Student> studentList = work.StudentRepository.GetList(filter: q => q.StudentNo == student.StudentNo);
                            if(studentList.Count == 0)
                            {
                               

                                Person person = new Person();
                                if (dt.Rows[i]["Gender"].ToString() == "Male")
                                {
                                    person.GenderId = 1;
                                }
                                else
                                {
                                    person.GenderId = 2;
                                }
                                person.Lastname = dt.Rows[i]["Lastname"].ToString();
                                person.Firstname = dt.Rows[i]["Firstname"].ToString();
                                person.Middlename = dt.Rows[i]["Middlename"].ToString();
                                person.Birthdate = (DateTime?)dt.Rows[i]["Birthdate"];

                                work.PersonRepository.Insert(person);

                                student.PersonId = person.PersonId;
                                work.StudentRepository.Insert(student);                          
                            }
                        }
                        loadData();
                    }

                }
            }
        }
    }
}
