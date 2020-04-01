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
        public Home()
        {
            InitializeComponent();
            customisedesign();
            hideSubMenu();
        }

        private void Home_Load(object sender, EventArgs e)
        {
    
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
            openChildForm(new Patient_Details());
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


        private void b_staff_Click(object sender, EventArgs e)
        {
            openChildForm(new Staff_Details());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

    }
}
