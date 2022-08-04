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
    public partial class questions_step3_Form : Form
    {
        public int Id { get; set; }
        public questions_step3_Form()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            // Get value questions 5
            if (question5.CheckedItems.Count > 0)
            {
                for (int i = 0; i < question5.CheckedItems.Count; i++)
                {
                    string v = question5.CheckedItems[i].ToString();
                    if (v != "")
                    {
                        person.question5 = i + 1;
                    }
                }
            }
            // Get value questions 6
            if (question6.CheckedItems.Count > 0)
            {
                for (int i = 0; i < question6.CheckedItems.Count; i++)
                {
                    string v = question6.CheckedItems[i].ToString();
                    if (v != "")
                    {
                        person.question6 = i + 1;
                    }
                }
            }
            // Get value questions 7
            if (question7.CheckedItems.Count > 0)
            {
                for (int i = 0; i < question7.CheckedItems.Count; i++)
                {
                    string v = question7.CheckedItems[i].ToString();
                    if (v != "")
                    {
                        person.question7 = i + 1;
                    }
                }
            }
            // Get value questions 8
            if (question8.CheckedItems.Count > 0)
            {
                for (int i = 0; i < question8.CheckedItems.Count; i++)
                {
                    string v = question8.CheckedItems[i].ToString();
                    if (v != "")
                    {
                        person.question8 = i + 1;
                    }
                }
            }

            PersonList personList = new PersonList();
            var obj = personList.lista.FirstOrDefault(x => x.Id == Id);

            obj.question5 = person.question5;
            obj.question6 = person.question6;
            obj.question7 = person.question7;
            obj.question8 = person.question8;
            this.Hide();
            questions_step4_Form form = new questions_step4_Form();
            form.Id = Id;
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            questions_step2_Form form = new questions_step2_Form();
            form.Show();
        }

        private void questions_step3_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
