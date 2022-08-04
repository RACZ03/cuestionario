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
    public partial class questions_step2_Form : Form
    {
        public int Id { get; set; }
        public questions_step2_Form()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            // Get value questions 1
            if ( question1.CheckedItems.Count > 0 )
            {
                for ( int i = 0; i < question1.CheckedItems.Count; i++ )
                {
                    string v = question1.CheckedItems[i].ToString();
                    if (v != "")
                    {
                        person.question1 = i + 1;
                    }
                }
            }
            // Get value questions 2
            if (question2.CheckedItems.Count > 0)
            {
                for (int i = 0; i < question2.CheckedItems.Count; i++)
                {
                    string v = question2.CheckedItems[i].ToString();
                    if (v != "")
                    {
                        person.question2 = i + 1;
                    }
                }
            }
            // Get value questions 3
            if (question3.CheckedItems.Count > 0)
            {
                for (int i = 0; i < question3.CheckedItems.Count; i++)
                {
                    string v = question3.CheckedItems[i].ToString();
                    if (v != "")
                    {
                        person.question3 = i + 1;
                    }
                }
            }
            // Get value questions 4
            if (question4.CheckedItems.Count > 0)
            {
                for (int i = 0; i < question4.CheckedItems.Count; i++)
                {
                    string v = question4.CheckedItems[i].ToString();
                    if (v != "")
                    {
                        person.question4 = i + 1;
                    }
                }
            }

            PersonList personList = new PersonList();
            var obj = personList.lista.FirstOrDefault(x => x.Id == Id);

            obj.question1 = person.question1;
            obj.question2 = person.question2;
            obj.question3 = person.question3;
            obj.question4 = person.question4;

            
            this.Hide();
            questions_step3_Form form = new questions_step3_Form();
            form.Id = Id;
            form.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            questions_step1_Form form = new questions_step1_Form();
            form.Show();
        }

        private void questions_step2_Form_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("User id: " + Id);
        }
    }
}
