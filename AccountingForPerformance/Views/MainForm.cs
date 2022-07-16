using AccountingForPerformance.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingForPerformance.Views
{
    public partial class MainForm : Form
    {
        #region IndicatorUC
        private Button CurrentIndicator;
        private void ChangeCurrentIndecator(Button btnIndicator)
        {
            if (CurrentIndicator != null)
            {
                CurrentIndicator.BackColor = Color.Transparent;
            }
            CurrentIndicator = btnIndicator;
            CurrentIndicator.BackColor = Color.GreenYellow;
        }
        #endregion


        public MainForm()
        {
            InitializeComponent();

            btnPerformance_Click(null, new EventArgs()); 
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_SIZEBOX = 0x40000;

                var cp = base.CreateParams;
                cp.Style |= WS_SIZEBOX;

                return cp;
            }
        }

        #region Title Panel

        private int x, y;
        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - x;
                Top += e.Y - y;
            }
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            x = Cursor.Position.X;
            y = Cursor.Position.Y;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            MaximizeClick();
        }
        private void pnlTittle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MaximizeClick();
        }

        private void pnlTittle_Paint(object sender, PaintEventArgs e)
        {
            MaximizeClick();
        }


        private Rectangle PrevSreen;
        private void MaximizeClick()
        {
            if (this.Bounds == Screen.PrimaryScreen.WorkingArea)
            {
                this.Bounds = PrevSreen;
            }
            else
            {
                PrevSreen = this.Bounds;
                this.Bounds = Screen.PrimaryScreen.WorkingArea;
            }
        }
        #endregion

        private PerformancePresenter performancePresenter;
        private void btnPerformance_Click(object sender, EventArgs e)
        {
            ChangeCurrentIndecator(btnPerformance);
            if(performancePresenter == null)
                performancePresenter = new Presenters.PerformancePresenter(examUC1);

            examUC1.BringToFront();
        }
        
        private ReportPresenter reportPresenter;
        private void btnReports_Click(object sender, EventArgs e)
        {
            ChangeCurrentIndecator(btnReports);
            
            if (reportPresenter == null)
                reportPresenter = new Presenters.ReportPresenter(reportUC1);

            reportUC1.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnMaximize_Click(null, new EventArgs());   // запуск ан весь экран + сохранение параметров дефолта
        }

        private ReferencePresenter referencePresenter;
        private void btnRefarances_Click(object sender, EventArgs e)
        {
            ChangeCurrentIndecator(btnRefarances);

            if (referencePresenter == null)
                referencePresenter = new Presenters.ReferencePresenter(referenceUC1);

            referenceUC1.BringToFront();
        }
        private void btnChart_Click(object sender, EventArgs e)
        {
            ChangeCurrentIndecator(btnChart);
            chartsUC1.BringToFront();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            (new AboutForm()).Show();
        }
    }
}
