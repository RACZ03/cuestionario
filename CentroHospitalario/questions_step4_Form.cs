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
    public partial class questions_step4_Form : Form
    {
        public int Id { get; set; }
        public questions_step4_Form()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            // Get value questions 9
            if (question9.CheckedItems.Count > 0)
            {
                for (int i = 0; i < question9.CheckedItems.Count; i++)
                {
                    string v = question9.CheckedItems[i].ToString();
                    if (v != "")
                    {
                        person.question9 = i + 1;
                    }
                }
            }
            // Get value questions 10
            if (question10.CheckedItems.Count > 0)
            {
                for (int i = 0; i < question10.CheckedItems.Count; i++)
                {
                    string v = question10.CheckedItems[i].ToString();
                    if (v != "")
                    {
                        person.question10 = i + 1;
                    }
                }
            }

            PersonList personList = new PersonList();
            var obj = personList.lista.FirstOrDefault(x => x.Id == Id);

            obj.question9 = person.question9;
            obj.question10 = person.question10;

            this.Hide();
            result_Form form = new result_Form();
            form.Id = Id;
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            questions_step3_Form form = new questions_step3_Form();
            form.Show();
        }

        private void questions_step4_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
