namespace AccountingForPerformance.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnMinimaze = new System.Windows.Forms.Button();
            this.btnMaximaze = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnRefarances = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlExams = new System.Windows.Forms.Panel();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.referenceUC1 = new AccountingForPerformance.UserControls.referenceUC();
            this.reportUC1 = new AccountingForPerformance.Views.ReportUC();
            this.examUC1 = new AccountingForPerformance.UserControls.ExamUC();
            this.chartsUC1 = new AccountingForPerformance.UserControls.ChartsUC();
            this.pnlTitle.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlExams.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Silver;
            this.pnlTitle.Controls.Add(this.btnMinimaze);
            this.pnlTitle.Controls.Add(this.btnMaximaze);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1318, 25);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseDoubleClick);
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Location = new System.Drawing.Point(1243, 0);
            this.btnMinimaze.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimaze.Name = "btnMinimaze";
            this.btnMinimaze.Size = new System.Drawing.Size(25, 25);
            this.btnMinimaze.TabIndex = 3;
            this.btnMinimaze.TabStop = false;
            this.btnMinimaze.Text = "_";
            this.btnMinimaze.UseVisualStyleBackColor = true;
            this.btnMinimaze.Click += new System.EventHandler(this.btnMinimaze_Click);
            // 
            // btnMaximaze
            // 
            this.btnMaximaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximaze.FlatAppearance.BorderSize = 0;
            this.btnMaximaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximaze.Location = new System.Drawing.Point(1268, 0);
            this.btnMaximaze.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximaze.Name = "btnMaximaze";
            this.btnMaximaze.Size = new System.Drawing.Size(25, 25);
            this.btnMaximaze.TabIndex = 2;
            this.btnMaximaze.TabStop = false;
            this.btnMaximaze.Text = "▭";
            this.btnMaximaze.UseVisualStyleBackColor = true;
            this.btnMaximaze.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1293, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Учёт уровня обучаемости";
            this.lblTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTittle_MouseDoubleClick);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightGray;
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Controls.Add(this.btnChart);
            this.pnlMenu.Controls.Add(this.btnRefarances);
            this.pnlMenu.Controls.Add(this.btnAbout);
            this.pnlMenu.Controls.Add(this.pnlExams);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 25);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(185, 622);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Location = new System.Drawing.Point(0, 112);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(185, 50);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Отчеты";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnChart
            // 
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Location = new System.Drawing.Point(0, 168);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(185, 50);
            this.btnChart.TabIndex = 6;
            this.btnChart.Text = "Графики";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnRefarances
            // 
            this.btnRefarances.FlatAppearance.BorderSize = 0;
            this.btnRefarances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefarances.Location = new System.Drawing.Point(-3, 56);
            this.btnRefarances.Name = "btnRefarances";
            this.btnRefarances.Size = new System.Drawing.Size(185, 50);
            this.btnRefarances.TabIndex = 5;
            this.btnRefarances.Text = "Справочники";
            this.btnRefarances.UseVisualStyleBackColor = true;
            this.btnRefarances.Click += new System.EventHandler(this.btnRefarances_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(0, 224);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(185, 50);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "О программе";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlExams
            // 
            this.pnlExams.BackColor = System.Drawing.Color.Transparent;
            this.pnlExams.Controls.Add(this.btnPerformance);
            this.pnlExams.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExams.Location = new System.Drawing.Point(0, 0);
            this.pnlExams.Name = "pnlExams";
            this.pnlExams.Size = new System.Drawing.Size(185, 50);
            this.pnlExams.TabIndex = 1;
            // 
            // btnPerformance
            // 
            this.btnPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPerformance.FlatAppearance.BorderSize = 0;
            this.btnPerformance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformance.Location = new System.Drawing.Point(0, 0);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Size = new System.Drawing.Size(185, 50);
            this.btnPerformance.TabIndex = 2;
            this.btnPerformance.Text = "Успеваемость";
            this.btnPerformance.UseVisualStyleBackColor = true;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // referenceUC1
            // 
            this.referenceUC1.DataSource = null;
            this.referenceUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.referenceUC1.Location = new System.Drawing.Point(185, 25);
            this.referenceUC1.Name = "referenceUC1";
            this.referenceUC1.Size = new System.Drawing.Size(1133, 622);
            this.referenceUC1.TabIndex = 4;
            // 
            // reportUC1
            // 
            this.reportUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportUC1.FilterDataSource = null;
            this.reportUC1.Location = new System.Drawing.Point(185, 25);
            this.reportUC1.Name = "reportUC1";
            this.reportUC1.PerfomanceDataSource = null;
            this.reportUC1.Size = new System.Drawing.Size(1133, 622);
            this.reportUC1.TabIndex = 3;
            // 
            // examUC1
            // 
            this.examUC1.CurrentAcademicYear = null;
            this.examUC1.CurrentEducationalInstitution = null;
            this.examUC1.CurrentSchoolClass = null;
            this.examUC1.CurrentTypeAssessment = null;
            this.examUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.examUC1.Location = new System.Drawing.Point(185, 25);
            this.examUC1.MinimumSize = new System.Drawing.Size(1015, 200);
            this.examUC1.Name = "examUC1";
            this.examUC1.Size = new System.Drawing.Size(1133, 622);
            this.examUC1.TabIndex = 2;
            this.examUC1.TableDataSource = null;
            // 
            // chartsUC1
            // 
            this.chartsUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartsUC1.Location = new System.Drawing.Point(185, 25);
            this.chartsUC1.Name = "chartsUC1";
            this.chartsUC1.Size = new System.Drawing.Size(1133, 622);
            this.chartsUC1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 647);
            this.Controls.Add(this.chartsUC1);
            this.Controls.Add(this.referenceUC1);
            this.Controls.Add(this.reportUC1);
            this.Controls.Add(this.examUC1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlExams.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMinimaze;
        private System.Windows.Forms.Button btnMaximaze;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlExams;
        private System.Windows.Forms.Button btnPerformance;
        private System.Windows.Forms.Button btnReports;
        private UserControls.ExamUC examUC1;
        private ReportUC reportUC1;
        private System.Windows.Forms.Button btnRefarances;
        private System.Windows.Forms.Button btnAbout;
        private UserControls.referenceUC referenceUC1;
        private System.Windows.Forms.Button btnChart;
        private UserControls.ChartsUC chartsUC1;
    }
}