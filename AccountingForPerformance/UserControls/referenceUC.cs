using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingForPerformance.Interfaces;

namespace AccountingForPerformance.UserControls
{
    public partial class referenceUC : UserControl, IReferencesView
    {
        DataGridView currentDataGrid;
        public referenceUC()
        {
            InitializeComponent();
            currentDataGrid = dataEI;
        }

        public object DataSource { get => currentDataGrid.DataSource; set { currentDataGrid.DataSource = null; currentDataGrid.DataSource = value; } }

        public object SelectRow
        {
            get
            {
                if (currentDataGrid.SelectedRows.Count > 0)
                {
                    return currentDataGrid.SelectedRows[0];
                }
                return null;
            }
        }

        int IReferencesView.SelectIndexTab => tabControl1.SelectedIndex;

        public event Action btnAddEI_OnClick;
        public event Action btnEditEI_OnClick;
        public event Action btnRemoveEI_OnClick;
        public event Action btnAddAY_OnClick;
        public event Action CurrentTab_Changed;

        private void btnAddAY_Click(object sender, EventArgs e)
        {
            btnAddAY_OnClick?.Invoke();
        }

        private void btnAddEI_Click(object sender, EventArgs e)
        {
            btnAddEI_OnClick?.Invoke();
        }

        private void btnEditEI_Click(object sender, EventArgs e)
        {
            btnEditEI_OnClick?.Invoke();
        }

        private void btnRemoveEI_Click(object sender, EventArgs e)
        {
            string message = "При удалении данной записи будут также удалены все связанные данные!\nВы дейстительно хотите удалить запись?";
            if (MessageBox.Show(message, "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                btnRemoveEI_OnClick?.Invoke();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0:
                    currentDataGrid = dataEI;
                    break;
                case 1:
                    currentDataGrid = dataYear;
                    break;
                case 2:
                    currentDataGrid = dataSubjects;
                    break;
                case 3:
                    currentDataGrid = dataClasses;
                    break;
                case 4:
                    currentDataGrid = dataLevelAssessments;
                    break;
            }


            CurrentTab_Changed?.Invoke();
        }

        private void dataSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void referenceUC_Load(object sender, EventArgs e)
        {
            
        }
    }
}
