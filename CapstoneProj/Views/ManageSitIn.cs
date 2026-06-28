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
    public partial class ManageSitIn : Form
    {
        public ManageSitIn()
        {
            InitializeComponent();
        }
        UnitOfWork work = new UnitOfWork();
        bool isChanged = false;
        private void btnCreateUpdate_Click(object sender, EventArgs e)
        {
            if(btnCreateUpdate.Text == "Time In")
            {
                int? studentId = Convert.ToInt32(cmbStudent.SelectedValue);
                int? termId = Convert.ToInt32(cmbTerm.SelectedValue);
                int? laboratoryId = Convert.ToInt32(cmbLaboratory.SelectedValue);
                int? computerId = Convert.ToInt32(cmbComputer.SelectedValue);

                studentId = studentId ?? 0;
                termId = termId ?? 0;
                laboratoryId = laboratoryId ?? 0;
                computerId = computerId ?? 0;

                DialogResult result = MessageBox.Show("Do you want to continue this action?", "Time In", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (studentId != 0 && termId != 0 && computerId != 0 && laboratoryId != 0)
                    {
                        Reservation studentActive = work.ReservationRepository.GetOne(filter: q => q.StudentId == studentId && q.DateStart <= DateTime.Now && q.StatusTypeId == 1);
                        Reservation computerAvailability = work.ReservationRepository.GetOne(filter: q => q.ComputerId == computerId && q.DateStart <= DateTime.Now && q.StatusTypeId == 1);
                        if(studentActive != null)
                        {
                            MessageBox.Show("An incomplete sit-in reservation is associated with this student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (computerAvailability != null)
                            {
                                MessageBox.Show("The current computer is currently in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                Reservation reservation = new Reservation
                                {
                                    StudentId = studentId,
                                    TermId = termId,
                                    ComputerId = computerId,
                                    LaboratoryId = laboratoryId,
                                    StatusTypeId = 1, //defaul value IN USED 
                                    DateStart = DateTime.Now
                                };

                                work.ReservationRepository.Insert(reservation);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Fill up all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                int reservationId = Convert.ToInt32(lblReservationId.Text);

                Reservation reservation = work.ReservationRepository.GetOne(filter: q => q.ReservationId == reservationId);



                Reservation reservationToUpdate = new Reservation()
                {
                    ReservationId = reservationId,
                    StudentId = reservation.StudentId,
                    TermId = reservation.TermId,
                    ComputerId = reservation.ComputerId,
                    LaboratoryId = reservation.LaboratoryId,
                    StatusTypeId = 2, //defaul value IN USED 
                    DateStart = reservation.DateStart,
                    DateEnd = DateTime.Now,
                    TimeConsumed = DateTime.Now - reservation.DateStart
                };

                work.ReservationRepository.Update(reservationToUpdate);
            }
            loadData();
            clearFields();
        }

        private void ManageSitIn_Load(object sender, EventArgs e)
        {
            loadData();
            GetStudentList(cmbStudent.Text);
            GetTermList(0);
            GetLaboratoryList(0);
        }

        public void GetStudetLogs(int? studentId, int? termId)
        {
            List<ViewLogs> sourceLogs = new List<ViewLogs>();
            List<Reservation> studentLogs = work.ReservationRepository.GetList(filter: q => q.StudentId == studentId && q.TermId == termId && q.StatusTypeId == 2);
            foreach (var item in studentLogs)
            {
                var xConsumed = string.Format("{0:00}:{1:00}:{2:00}", item.TimeConsumed.Value.Hours, item.TimeConsumed.Value.Minutes, item.TimeConsumed.Value.Seconds);
                ViewLogs pData = new ViewLogs
                {
                    DateStart = (DateTime)item.DateStart,
                    DateEnd = (DateTime)item.DateEnd,
                    Total = xConsumed
                };

                sourceLogs.Add(pData);
            }
            dgvStudentData.DataSource = sourceLogs;
        }
        public void GetComputerList(int? computerId, int? laboratoryId)
        {
            computerId = computerId ?? 0;
            laboratoryId = laboratoryId ?? 0;
            List<Computer> computerList = work.ComputerRepository.GetList(filter: q => (q.IsActive == true && (q.LaboratoryId == laboratoryId) || q.ComputerId == computerId));
            cmbComputer.DataSource = computerList;
            cmbComputer.ValueMember = "ComputerId";
            cmbComputer.DisplayMember = "ComputerName";
            cmbComputer.SelectedItem = null;
        }
        public void GetTermList(int? termId)
        {
            termId = termId ?? 0;
            List<Term> termList = work.TermRepository.GetList(filter: q => q.IsActive == true || q.TermId == termId);
            cmbTerm.DataSource = termList;
            cmbTerm.ValueMember = "TermId";
            cmbTerm.DisplayMember = "TermName";
            cmbTerm.SelectedItem = null;
        }

        public void GetLaboratoryList(int? laboratoryId)
        {
            laboratoryId = laboratoryId ?? 0;
            List<Laboratory> laboratoryList = work.LaboratoryRepository.GetList(filter: q => q.IsActive == true || q.LaboratoryId == laboratoryId);
            cmbLaboratory.SelectedItem = null;
            cmbLaboratory.ValueMember = "LaboratoryId";
            cmbLaboratory.DisplayMember = "LaboratoryName";
            cmbLaboratory.DataSource = laboratoryList;
        }

        public void GetStudentList(string searchString)
        {
            List<Student> personList = new List<Student>();
            searchString = searchString ?? "";
            personList = work.StudentRepository.GetList(filter: q => q.Person.Firstname.StartsWith(searchString) || q.Person.Lastname.StartsWith(searchString) || q.StudentNo.StartsWith(searchString), includeProperties: "Person", iDisplayStart: 0, iDisplayLength: 10); 
            
            if(personList.Count == 0)
            {
                MessageBox.Show("No matches found. Please verify your search..", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            var x = personList.Select(q => new { Id = q.StudentId, Text = q.DisplayName}).ToList();

            cmbStudent.DataSource = x;
            cmbStudent.ValueMember = "Id";
            cmbStudent.DisplayMember = "Text";
            if(!isChanged)
            {
                cmbStudent.SelectedItem = null;
            }
            
        }

        private void cmbStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            isChanged = true;
        }

        private void cmbStudent_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTerm.SelectedValue != null)
            {
                int id = Convert.ToInt32(cmbStudent.SelectedValue);
                TimeSpan totalHours = new TimeSpan(1, 0, 0, 0);
                TimeSpan timeConsumed = new TimeSpan(0, 0, 0, 0);

                List<Reservation> reservationsList = work.ReservationRepository.GetList(filter: q => q.StudentId == id && q.StatusTypeId == 2);

                foreach (var item in reservationsList)
                {       
                    timeConsumed = (TimeSpan)(timeConsumed + item.TimeConsumed); 
                }
                if (timeConsumed != null)
                {
                    TimeSpan timeDifference = (TimeSpan)(totalHours - timeConsumed);
                    txtRemaining.Text = string.Format("{0:00}:{1:00}:{2:00}", timeDifference.Hours, timeDifference.Minutes, timeDifference.Seconds);
                    txtConsume.Text = string.Format("{0:00}:{1:00}:{2:00}", timeConsumed.Hours, timeConsumed.Minutes, timeConsumed.Seconds);
                }
                else
                {
                    txtRemaining.Text = string.Format("{0:00}:{1:00}:{2:00}", totalHours.Hours, totalHours.Minutes, totalHours.Seconds);
                }
                isChanged = false;

                //LOAD STUDENT LOGS
                int studentId = Convert.ToInt32(cmbStudent.SelectedValue);
                int termId = Convert.ToInt32(cmbTerm.SelectedValue);
                GetStudetLogs(studentId, termId);
            }

        }

        private void cmbTerm_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbStudent.SelectedValue != null)
            {
                int id = Convert.ToInt32(cmbStudent.SelectedValue);
                TimeSpan totalHours = new TimeSpan(1, 0, 0, 0);
                TimeSpan timeConsumed = new TimeSpan(0, 0, 0, 0);

                List<Reservation> reservationsList = work.ReservationRepository.GetList(filter: q => q.StudentId == id && q.StatusTypeId == 2);

                foreach (var item in reservationsList)
                {
                   
                    timeConsumed = (TimeSpan)(timeConsumed + item.TimeConsumed);
                    
                }
                if (timeConsumed != null)
                {
                    TimeSpan timeDifference = (TimeSpan)(totalHours - timeConsumed);
                    txtRemaining.Text = string.Format("{0:00}:{1:00}:{2:00}", timeDifference.Hours, timeDifference.Minutes, timeDifference.Seconds);
                    txtConsume.Text = string.Format("{0:00}:{1:00}:{2:00}", timeConsumed.Hours, timeConsumed.Minutes, timeConsumed.Seconds);
                }
                else
                {
                    txtRemaining.Text = string.Format("{0:00}:{1:00}:{2:00}", totalHours.Hours, totalHours.Minutes, totalHours.Seconds);
                }
                isChanged = false;

                //LOAD STUDENT LOGS
                int studentId = Convert.ToInt32(cmbStudent.SelectedValue);
                int termId = Convert.ToInt32(cmbTerm.SelectedValue);
                GetStudetLogs(studentId, termId);

            }
        }

        private void cmbLaboratory_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbLaboratory.SelectedValue != null)
            {
                int? laboratoryId = Convert.ToInt32(cmbLaboratory.SelectedValue);
                laboratoryId = laboratoryId ?? 0;

                if (laboratoryId != 0)
                {
                    GetComputerList(0, laboratoryId);

                }
            } 
        }

        public class ViewDetail
        {
            public int ReservationId { get; set; }
            public string StudentNo { get; set; }
            public string Lastname { get; set; }
            public string Firstname { get; set; }
            public string Laboratory { get; set; }
            public string Computer { get; set; }
            public DateTime DateStarted { get; set; }
            public string Status { get; set; }
        }

        public class ViewLogs
        {
            public DateTime DateStart { get; set; }
            public DateTime DateEnd { get; set; }
            public string Total { get; set; }
        }

        public void loadData()
        {
            List<Reservation> reservationList = work.ReservationRepository.GetList(filter: q => q.StatusTypeId == 1, includeProperties: "Student.Person, StatusType, Computer.Laboratory");


            List<ViewDetail> source = new List<ViewDetail>();

            foreach (var item in reservationList)
            {
                ViewDetail pData = new ViewDetail
                {
                    ReservationId = item.ReservationId,
                    StudentNo = item.Student.StudentNo,
                    Lastname = item.Student.Person.Lastname,
                    Firstname = item.Student.Person.Middlename,

                    Laboratory = item.Computer.Laboratory.LaboratoryName,
                    Computer = item.Computer.ComputerName,
                    DateStarted = (DateTime)item.DateStart,
                    Status = item.StatusType.StatusTypeName
                };

                source.Add(pData);
            }
            dgvSitin.DataSource = source;
           
        }

        private void dgvSitin_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ReservationId = Convert.ToInt32(dgvSitin.CurrentRow.Cells[0].Value);

            Reservation reservation = work.ReservationRepository.GetOne(filter: q => q.ReservationId == ReservationId, includeProperties:"Student");
            GetStudentList(reservation.Student.StudentNo);
            GetTermList(reservation.TermId);
            GetLaboratoryList(reservation.LaboratoryId);
            GetComputerList(reservation.ComputerId, reservation.LaboratoryId);
            cmbStudent.SelectedIndex = 0;
            cmbTerm.SelectedIndex = 0;
            cmbLaboratory.SelectedIndex = 0;
            cmbComputer.SelectedIndex = 0;
            btnCreateUpdate.Text = "Time Out";
            lblReservationId.Text = reservation.ReservationId.ToString();
        }

        private void cmbStudent_Leave(object sender, EventArgs e)
        {
            if(isChanged)
            {
                GetStudentList(cmbStudent.Text);
                isChanged = false;
            }
        }

        public void clearFields()
        {
            cmbStudent.SelectedItem = null;
            cmbTerm.SelectedItem = null;
            cmbLaboratory.SelectedItem = null;
            cmbComputer.SelectedItem = null;
            txtConsume.Text = "";
            txtRemaining.Text = "";
            btnCreateUpdate.Text = "Time In";
            dgvStudentData.DataSource = null;
            
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
