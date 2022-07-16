using AccountingForPerformance.Entities;
using AccountingForPerformance.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AccountingForPerformance.Views
{
    public partial class EIWork : Form
    {
        IDataContext db;
        bool isEdeted;
        string currentName;
        public EIWork(IDataContext dataContext, string nameEI = "", bool isEdeted = false)
        {
            InitializeComponent();
            db = dataContext;
            this.isEdeted = isEdeted;
            currentName = nameEI;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isEdeted)
            {
                if (db.EducationalInstitutions.Where(i => i.Name.Equals(txtEI.Text)).Count() > 0)
                {
                    MessageBox.Show("УО с таким наименованием уже существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                db.EducationalInstitutions.Add(new Entities.EducationalInstitution { Name = txtEI.Text });
                db.SaveChanges();
            }
            else
            {
                EducationalInstitution educationalInstitution = db.EducationalInstitutions.Where(i => i.Name.Equals(currentName)).FirstOrDefault();
                //db.EducationalInstitutions.Remove(educationalInstitution);
                //db.EducationalInstitutions.Add(new Entities.EducationalInstitution { Id = educationalInstitution.Id, Name = txtEI.Text });
                educationalInstitution.Name = txtEI.Text;
                db.SaveChanges();
            }

            this.Close();
        }
    }
}
