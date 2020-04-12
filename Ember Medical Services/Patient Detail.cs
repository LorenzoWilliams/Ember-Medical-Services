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



            

        }

    }
}
