namespace AccountingForPerformance.UserControls
{
    partial class ExamUC
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamUC));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            this.cmbSchoolClasses = new System.Windows.Forms.ComboBox();
            this.lblSchoolClass = new System.Windows.Forms.Label();
            this.cmblAcademicYears = new System.Windows.Forms.ComboBox();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.cmbTypeAssessment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEducationalInstitutions = new System.Windows.Forms.ComboBox();
            this.lblEducationalInstitution = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCountTotal = new System.Windows.Forms.Label();
            this.lblCountHighLevel = new System.Windows.Forms.Label();
            this.lblCountSufficientLevel = new System.Windows.Forms.Label();
            this.lblCountMidleLevel = new System.Windows.Forms.Label();
            this.lblCountSatisfactoryLevel = new System.Windows.Forms.Label();
            this.lblCountLowLevel = new System.Windows.Forms.Label();
            this.lblCountFailedLevel = new System.Windows.Forms.Label();
            this.lblAverageMark = new System.Windows.Forms.Label();
            this.lblQualityPercentage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLevelEducationalActivity = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnImport);
            this.pnlMenu.Controls.Add(this.btnExport);
            this.pnlMenu.Controls.Add(this.cmbSchoolClasses);
            this.pnlMenu.Controls.Add(this.lblSchoolClass);
            this.pnlMenu.Controls.Add(this.cmblAcademicYears);
            this.pnlMenu.Controls.Add(this.lblAcademicYear);
            this.pnlMenu.Controls.Add(this.cmbTypeAssessment);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.cmbEducationalInstitutions);
            this.pnlMenu.Controls.Add(this.lblEducationalInstitution);
            this.pnlMenu.Controls.Add(this.btnUpdate);
            this.pnlMenu.Controls.Add(this.btnRemove);
            this.pnlMenu.Controls.Add(this.btnEdit);
            this.pnlMenu.Controls.Add(this.btnAdd);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1132, 60);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.ImageIndex = 0;
            this.btnImport.ImageList = this.imageList1;
            this.btnImport.Location = new System.Drawing.Point(863, 31);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(238, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Импорт";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-импортировать-90.png");
            this.imageList1.Images.SetKeyName(1, "icons8-экспорт-90.png");
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.ImageIndex = 1;
            this.btnExport.ImageList = this.imageList1;
            this.btnExport.Location = new System.Drawing.Point(863, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(238, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "   Экспорт";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cmbSchoolClasses
            // 
            this.cmbSchoolClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchoolClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSchoolClasses.FormattingEnabled = true;
            this.cmbSchoolClasses.Location = new System.Drawing.Point(702, 33);
            this.cmbSchoolClasses.Name = "cmbSchoolClasses";
            this.cmbSchoolClasses.Size = new System.Drawing.Size(133, 21);
            this.cmbSchoolClasses.TabIndex = 2;
            this.cmbSchoolClasses.TabStop = false;
            this.cmbSchoolClasses.SelectedIndexChanged += new System.EventHandler(this.cmbSchoolClasses_SelectedIndexChanged);
            // 
            // lblSchoolClass
            // 
            this.lblSchoolClass.AutoSize = true;
            this.lblSchoolClass.Location = new System.Drawing.Point(655, 36);
            this.lblSchoolClass.Name = "lblSchoolClass";
            this.lblSchoolClass.Size = new System.Drawing.Size(41, 13);
            this.lblSchoolClass.TabIndex = 1;
            this.lblSchoolClass.Text = "Класс:";
            // 
            // cmblAcademicYears
            // 
            this.cmblAcademicYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblAcademicYears.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmblAcademicYears.FormattingEnabled = true;
            this.cmblAcademicYears.Location = new System.Drawing.Point(734, 5);
            this.cmblAcademicYears.Name = "cmblAcademicYears";
            this.cmblAcademicYears.Size = new System.Drawing.Size(101, 21);
            this.cmblAcademicYears.TabIndex = 2;
            this.cmblAcademicYears.TabStop = false;
            this.cmblAcademicYears.SelectedIndexChanged += new System.EventHandler(this.cmblAcademicYears_SelectedIndexChanged);
            // 
            // lblAcademicYear
            // 
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.Location = new System.Drawing.Point(653, 8);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(75, 13);
            this.lblAcademicYear.TabIndex = 1;
            this.lblAcademicYear.Text = "Учебный год:";
            // 
            // cmbTypeAssessment
            // 
            this.cmbTypeAssessment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTypeAssessment.FormattingEnabled = true;
            this.cmbTypeAssessment.Location = new System.Drawing.Point(391, 33);
            this.cmbTypeAssessment.Name = "cmbTypeAssessment";
            this.cmbTypeAssessment.Size = new System.Drawing.Size(250, 21);
            this.cmbTypeAssessment.TabIndex = 2;
            this.cmbTypeAssessment.TabStop = false;
            this.cmbTypeAssessment.SelectedIndexChanged += new System.EventHandler(this.cmbTypeAssessment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Период успеваемости:";
            // 
            // cmbEducationalInstitutions
            // 
            this.cmbEducationalInstitutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationalInstitutions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEducationalInstitutions.FormattingEnabled = true;
            this.cmbEducationalInstitutions.Location = new System.Drawing.Point(378, 5);
            this.cmbEducationalInstitutions.Name = "cmbEducationalInstitutions";
            this.cmbEducationalInstitutions.Size = new System.Drawing.Size(263, 21);
            this.cmbEducationalInstitutions.TabIndex = 2;
            this.cmbEducationalInstitutions.TabStop = false;
            this.cmbEducationalInstitutions.SelectedIndexChanged += new System.EventHandler(this.cmbEducationalInstitutions_SelectedIndexChanged);
            // 
            // lblEducationalInstitution
            // 
            this.lblEducationalInstitution.AutoSize = true;
            this.lblEducationalInstitution.Location = new System.Drawing.Point(262, 8);
            this.lblEducationalInstitution.Name = "lblEducationalInstitution";
            this.lblEducationalInstitution.Size = new System.Drawing.Size(110, 13);
            this.lblEducationalInstitution.TabIndex = 1;
            this.lblEducationalInstitution.Text = "Учебное заведение:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(185, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 50);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.TabStop = false;
            this.toolTip1.SetToolTip(this.btnUpdate, "Обновить");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(125, 5);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 50);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRemove, "Удалить");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(65, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEdit, "Изменить");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(5, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdd, "Добавить");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 60);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1132, 495);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Итого:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblCountTotal);
            this.flowLayoutPanel1.Controls.Add(this.lblCountHighLevel);
            this.flowLayoutPanel1.Controls.Add(this.lblCountSufficientLevel);
            this.flowLayoutPanel1.Controls.Add(this.lblCountMidleLevel);
            this.flowLayoutPanel1.Controls.Add(this.lblCountSatisfactoryLevel);
            this.flowLayoutPanel1.Controls.Add(this.lblCountLowLevel);
            this.flowLayoutPanel1.Controls.Add(this.lblCountFailedLevel);
            this.flowLayoutPanel1.Controls.Add(this.lblAverageMark);
            this.flowLayoutPanel1.Controls.Add(this.lblQualityPercentage);
            this.flowLayoutPanel1.Controls.Add(this.lblLevelEducationalActivity);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1126, 41);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblCountTotal
            // 
            this.lblCountTotal.AutoSize = true;
            this.lblCountTotal.Location = new System.Drawing.Point(5, 3);
            this.lblCountTotal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCountTotal.Name = "lblCountTotal";
            this.lblCountTotal.Size = new System.Drawing.Size(120, 13);
            this.lblCountTotal.TabIndex = 0;
            this.lblCountTotal.Text = "Количество учащихся:";
            // 
            // lblCountHighLevel
            // 
            this.lblCountHighLevel.AutoSize = true;
            this.lblCountHighLevel.Location = new System.Drawing.Point(135, 3);
            this.lblCountHighLevel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCountHighLevel.Name = "lblCountHighLevel";
            this.lblCountHighLevel.Size = new System.Drawing.Size(99, 13);
            this.lblCountHighLevel.TabIndex = 1;
            this.lblCountHighLevel.Text = "Высокий уровень:";
            // 
            // lblCountSufficientLevel
            // 
            this.lblCountSufficientLevel.AutoSize = true;
            this.lblCountSufficientLevel.Location = new System.Drawing.Point(244, 3);
            this.lblCountSufficientLevel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCountSufficientLevel.Name = "lblCountSufficientLevel";
            this.lblCountSufficientLevel.Size = new System.Drawing.Size(122, 13);
            this.lblCountSufficientLevel.TabIndex = 5;
            this.lblCountSufficientLevel.Text = "Достаточный уровень:";
            // 
            // lblCountMidleLevel
            // 
            this.lblCountMidleLevel.AutoSize = true;
            this.lblCountMidleLevel.Location = new System.Drawing.Point(376, 3);
            this.lblCountMidleLevel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCountMidleLevel.Name = "lblCountMidleLevel";
            this.lblCountMidleLevel.Size = new System.Drawing.Size(97, 13);
            this.lblCountMidleLevel.TabIndex = 2;
            this.lblCountMidleLevel.Text = "Средний уровень:";
            // 
            // lblCountSatisfactoryLevel
            // 
            this.lblCountSatisfactoryLevel.AutoSize = true;
            this.lblCountSatisfactoryLevel.Location = new System.Drawing.Point(483, 3);
            this.lblCountSatisfactoryLevel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCountSatisfactoryLevel.Name = "lblCountSatisfactoryLevel";
            this.lblCountSatisfactoryLevel.Size = new System.Drawing.Size(164, 13);
            this.lblCountSatisfactoryLevel.TabIndex = 3;
            this.lblCountSatisfactoryLevel.Text = "Удовлетворительный уровень:";
            // 
            // lblCountLowLevel
            // 
            this.lblCountLowLevel.AutoSize = true;
            this.lblCountLowLevel.Location = new System.Drawing.Point(657, 3);
            this.lblCountLowLevel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCountLowLevel.Name = "lblCountLowLevel";
            this.lblCountLowLevel.Size = new System.Drawing.Size(92, 13);
            this.lblCountLowLevel.TabIndex = 4;
            this.lblCountLowLevel.Text = "Низкий уровень:";
            // 
            // lblCountFailedLevel
            // 
            this.lblCountFailedLevel.AutoSize = true;
            this.lblCountFailedLevel.Location = new System.Drawing.Point(759, 3);
            this.lblCountFailedLevel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblCountFailedLevel.Name = "lblCountFailedLevel";
            this.lblCountFailedLevel.Size = new System.Drawing.Size(92, 13);
            this.lblCountFailedLevel.TabIndex = 6;
            this.lblCountFailedLevel.Text = "Не аттестованы:";
            // 
            // lblAverageMark
            // 
            this.lblAverageMark.AutoSize = true;
            this.lblAverageMark.Location = new System.Drawing.Point(861, 3);
            this.lblAverageMark.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblAverageMark.Name = "lblAverageMark";
            this.lblAverageMark.Size = new System.Drawing.Size(74, 13);
            this.lblAverageMark.TabIndex = 7;
            this.lblAverageMark.Text = "Средний бал:";
            // 
            // lblQualityPercentage
            // 
            this.lblQualityPercentage.AutoSize = true;
            this.lblQualityPercentage.Location = new System.Drawing.Point(945, 3);
            this.lblQualityPercentage.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblQualityPercentage.Name = "lblQualityPercentage";
            this.lblQualityPercentage.Size = new System.Drawing.Size(110, 13);
            this.lblQualityPercentage.TabIndex = 8;
            this.lblQualityPercentage.Text = "Качество знаний, %:";
            // 
            // lblLevelEducationalActivity
            // 
            this.lblLevelEducationalActivity.AutoSize = true;
            this.lblLevelEducationalActivity.Location = new System.Drawing.Point(5, 22);
            this.lblLevelEducationalActivity.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblLevelEducationalActivity.Name = "lblLevelEducationalActivity";
            this.lblLevelEducationalActivity.Size = new System.Drawing.Size(236, 13);
            this.lblLevelEducationalActivity.TabIndex = 9;
            this.lblLevelEducationalActivity.Text = "Уровень результатов учебной деятельности:";
            // 
            // ExamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.pnlMenu);
            this.MinimumSize = new System.Drawing.Size(850, 200);
            this.Name = "ExamUC";
            this.Size = new System.Drawing.Size(1132, 555);
            this.Load += new System.EventHandler(this.ExamUC_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCountTotal;
        private System.Windows.Forms.Label lblCountHighLevel;
        private System.Windows.Forms.Label lblCountSufficientLevel;
        private System.Windows.Forms.Label lblCountMidleLevel;
        private System.Windows.Forms.Label lblCountSatisfactoryLevel;
        private System.Windows.Forms.Label lblCountLowLevel;
        private System.Windows.Forms.Label lblCountFailedLevel;
        private System.Windows.Forms.Label lblAverageMark;
        private System.Windows.Forms.Label lblQualityPercentage;
        private System.Windows.Forms.ComboBox cmbSchoolClasses;
        private System.Windows.Forms.Label lblSchoolClass;
        private System.Windows.Forms.ComboBox cmblAcademicYears;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.ComboBox cmbTypeAssessment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEducationalInstitutions;
        private System.Windows.Forms.Label lblEducationalInstitution;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblLevelEducationalActivity;
    }
}
