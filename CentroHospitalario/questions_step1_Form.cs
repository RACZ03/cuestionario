using System;
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
    public partial class questions_step1_Form : Form
    {
        public questions_step1_Form()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form();
            form.Show();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtApe.Text != "" && txtPhone.Text != "" && txtDir.Text != "") {
                
                Random random = new Random();
                Person person = new Person();
                person.Id = random.Next(100, 999);
                person.Name = txtName.Text;
                person.Ape = txtApe.Text;
                person.Phone = txtPhone.Text;
                person.Dir = txtDir.Text;

                PersonList personList = new PersonList();
                personList.lista.Add(person);

                this.Hide();
                questions_step2_Form form = new questions_step2_Form();
                form.Id = person.Id;
                form.Show();

            } else
            {
                MessageBox.Show("Por favor llenar los datos");
            }
        }
    }
}
