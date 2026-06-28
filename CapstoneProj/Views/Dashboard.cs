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

namespace CapstoneProj.Views
{
    public partial class Dashboard : Form
    {
        UnitOfWork work = new UnitOfWork();
        public Dashboard()
        {
            InitializeComponent();
        }

        public class ViewDetail
        {
            public int ReservationId { get; set; }
            public string FullName { get; set; }
            public string Laboratory { get; set; }
            public string Computer { get; set; }
            public DateTime DateStart { get; set; }
            public DateTime DateEnd { get; set; }
            public string Total { get; set; }


        }
        private void btnView_Click(object sender, EventArgs e)
        {
            loadData(dtpStart.Value, dtpEnd.Value);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            setdtpTime();
            DateTime dailyStart = DateTime.Now.Date;
            DateTime dailyEnd = DateTime.Now.Date.AddDays(1).AddTicks(-1);
            DateTime monthStart = new DateTime(dailyStart.Year, dailyStart.Month, 1);
            DateTime monthEnd = monthStart.AddMonths(1).AddDays(-1);
            lblDaily.Text = work.ReservationRepository.GetList(filter: q => q.DateStart >= dailyStart && q.DateEnd <= dailyEnd).Count().ToString();
            lblDailyActive.Text = work.ReservationRepository.GetList(filter: q => q.DateStart >= dailyStart && q.StatusTypeId == 1).Count().ToString();
            lblMonthly.Text = work.ReservationRepository.GetList(filter: q => q.DateEnd >= monthStart && q.DateEnd <= monthEnd).Count().ToString();

            loadData(dtpStart.Value, dtpEnd.Value);
        }

        public void loadData(DateTime start, DateTime end)
        {
            List<Reservation> reservations = work.ReservationRepository.GetList(filter: q => q.DateStart >= start && q.DateEnd <= end).ToList();

            List<ViewDetail> source = new List<ViewDetail>();
            foreach (var item in reservations)
            {
                var xTotal = string.Format("{0:00}:{1:00}:{2:00}", item.TimeConsumed.Value.Hours, item.TimeConsumed.Value.Minutes, item.TimeConsumed.Value.Seconds);
                ViewDetail tData = new ViewDetail
                {
                    ReservationId = item.ReservationId,
                    FullName = item.Student.DisplayName,
                    Laboratory = item.Laboratory.LaboratoryName,
                    Computer = item.Computer.ComputerCode,
                    DateStart = (DateTime)item.DateStart,
                    DateEnd = (DateTime)item.DateEnd,
                    Total = xTotal,

                };

                source.Add(tData);
            }

            dgvReportList.DataSource = source;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            setdtpTime();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            setdtpTime();
        }

        public void setdtpTime()
        {
            DateTime selectedstartDate = dtpStart.Value;
            // Set the time component to 12:00 AM (midnight)
            DateTime selectedDateWithMidnightTime = selectedstartDate.Date;
            // Update the DateTimePicker value
            dtpStart.Value = selectedDateWithMidnightTime;

            DateTime selectedendDate = dtpEnd.Value;
            // Set the time component to 11:59 PM (last seconds before next day)
            DateTime selectedDateWithLastTime = selectedendDate.Date.AddDays(1).AddTicks(-1);
            // Update the DateTimePicker value
            dtpEnd.Value = selectedDateWithLastTime;
        }
    }
}
