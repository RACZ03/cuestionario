﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroHospitalario
{
    public partial class questions_step2_Form : Form
    {
        public questions_step2_Form()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            questions_step3_Form form = new questions_step3_Form();
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            questions_step1_Form form = new questions_step1_Form();
            form.Show();
        }

    }
}
