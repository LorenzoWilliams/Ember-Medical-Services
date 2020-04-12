using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ember_Medical_Services
{
    public partial class Home : Form
    {
        private  Ember_medical_service_db ember_Medical_Service_Db;

        public Home()
        {
            InitializeComponent();
            customisedesign();
            hideSubMenu();
            ember_Medical_Services_Db = new Ember_medical_service_db();
        }

        private void customisedesign()
        {
            panel_patient.Visible = false;
            panel_staff.Visible = false;
            panel_appointment.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_patient.Visible == true)
                panel_patient.Visible = false;
            if (panel_staff.Visible == true)
                panel_staff.Visible = false;
            if (panel_appointment.Visible == true)
                panel_appointment.Visible = false;
        }
        private void showSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else
                panel.Visible = false;

        }

        private void Patient_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_patient);
        }

        private void bt_addpt_Click(object sender, EventArgs e)
        {
            var patientDetails = new Patient_Details();
            patientDetails.Show();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_staff);
        }

        private void Appointment_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_appointment);
        }

        private void b_Report_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private Ember_medical_service_db ember_Medical_Services_Db;



        private void b_addStaff_Click(object sender, EventArgs e)
        {
            var staff_details = new Staff_Details();
            staff_details.Show();
        }

        private void b_makeAppointment_Click(object sender, EventArgs e)
        {
           
            var scheduleAppointments = new ScheduleAppointment();
            scheduleAppointments.Show();
        }

        private void b_ViewAppointment_Click(object sender, EventArgs e)
        {
            var viewAppointments =new ViewAppointments();
            viewAppointments.Show();
        }

        private void bt_ptinfo_Click(object sender, EventArgs e)
        {
            var viewPatients = new ViewPatients();
            viewPatients.Show();
            //var ptinfo = ember_Medical_Service_Db.Patients.ToList();
   
        }

        private void bt_viewStaff_Click(object sender, EventArgs e)
        {
            var viewStaffs = new ViewStaffs();
            viewStaffs.Show();
        }
    }
}
