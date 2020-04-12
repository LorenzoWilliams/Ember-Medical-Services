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
    public partial class Patient_Details : Form
    {
<<<<<<< HEAD
        private Ember_medical_service_db ember_Medical_Services_Db;

        public Patient_Details()
        {
            InitializeComponent();
            ember_Medical_Services_Db = new Ember_medical_service_db();
        }

        private void b_next_Click(object sender, EventArgs e)
        {
            var patientDetails2 = new Patient_Details2();
            patientDetails2.Show();
        }
=======
        private readonly Ember_medical_service_dbEntities EmberMedicalService_dbEntities;
        public Patient_Details()
        {
            InitializeComponent();

            EmberMedicalService_dbEntities = new Ember_medical_service_dbEntities();
        }

        private void BntPatientNxtPage_Click(object sender, EventArgs e)
        {
            Patient_Details2 patient_Details2 = new Patient_Details2();
           
            
        
           // patient_Details2.Show();



            
>>>>>>> b3c75119abddbf81475428ea1d0533eddc715aa6

        private void Patient_Details_Load(object sender, EventArgs e)
        {
            var patientDetails = new Patient_Details();
           
        }

    }
}
