﻿using System;
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

        private void Patient_Details_Load(object sender, EventArgs e)
        {
            var patientDetails = new Patient_Details();
           
        }
    }
}
