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
    public partial class ViewPatients : Form
    {
        private Ember_medical_service_db ember_Medical_Services_Db;

        public ViewPatients()
        {
            InitializeComponent();
            ember_Medical_Services_Db = new Ember_medical_service_db();
        }

        private void ViewPatients_Load(object sender, EventArgs e)
        {
           // var viewPatient = ember_Medical_Services_Db.Patients.ToList();
            

        }

    }
}
