namespace AccountingForPerformance.Views
{
    partial class ReportUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataFilter = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemoveEI = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataPerfomances = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmblAcademicYears = new System.Windows.Forms.ComboBox();
            this.lblAcademicYear = new System.Windows.Forms.Label();
            this.cmbEducationalInstitutions = new System.Windows.Forms.ComboBox();
            this.lblEducationalInstitution = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportYears = new System.Windows.Forms.Button();
            this.btnExportExamYear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFilter)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerfomances)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 569);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 491);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataFilter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(367, 491);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataFilter
            // 
            this.dataFilter.AllowUserToAddRows = false;
            this.dataFilter.AllowUserToDeleteRows = false;
            this.dataFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFilter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataFilter.BackgroundColor = System.Drawing.Color.White;
            this.dataFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFilter.Location = new System.Drawing.Point(3, 3);
            this.dataFilter.Name = "dataFilter";
            this.dataFilter.ReadOnly = true;
            this.dataFilter.RowHeadersVisible = false;
            this.dataFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFilter.Size = new System.Drawing.Size(361, 449);
            this.dataFilter.TabIndex = 0;
            this.dataFilter.SelectionChanged += new System.EventHandler(this.dataFilter_SelectionChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnClear, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveEI, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 458);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(361, 30);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(183, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 24);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemoveEI
            // 
            this.btnRemoveEI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveEI.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveEI.Name = "btnRemoveEI";
            this.btnRemoveEI.Size = new System.Drawing.Size(174, 24);
            this.btnRemoveEI.TabIndex = 2;
            this.btnRemoveEI.Text = "Удалить";
            this.btnRemoveEI.UseVisualStyleBackColor = true;
            this.btnRemoveEI.Click += new System.EventHandler(this.btnRemoveEI_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dataPerfomances, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(693, 491);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dataPerfomances
            // 
            this.dataPerfomances.AllowUserToAddRows = false;
            this.dataPerfomances.AllowUserToDeleteRows = false;
            this.dataPerfomances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPerfomances.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPerfomances.BackgroundColor = System.Drawing.Color.White;
            this.dataPerfomances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerfomances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPerfomances.Location = new System.Drawing.Point(3, 3);
            this.dataPerfomances.Name = "dataPerfomances";
            this.dataPerfomances.ReadOnly = true;
            this.dataPerfomances.RowHeadersVisible = false;
            this.dataPerfomances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPerfomances.Size = new System.Drawing.Size(687, 485);
            this.dataPerfomances.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cmblAcademicYears);
            this.panel1.Controls.Add(this.lblAcademicYear);
            this.panel1.Controls.Add(this.cmbEducationalInstitutions);
            this.panel1.Controls.Add(this.lblEducationalInstitution);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 29);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(585, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmblAcademicYears
            // 
            this.cmblAcademicYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblAcademicYears.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmblAcademicYears.FormattingEnabled = true;
            this.cmblAcademicYears.Location = new System.Drawing.Point(478, 6);
            this.cmblAcademicYears.Name = "cmblAcademicYears";
            this.cmblAcademicYears.Size = new System.Drawing.Size(101, 21);
            this.cmblAcademicYears.TabIndex = 8;
            this.cmblAcademicYears.TabStop = false;
            // 
            // lblAcademicYear
            // 
            this.lblAcademicYear.AutoSize = true;
            this.lblAcademicYear.Location = new System.Drawing.Point(397, 9);
            this.lblAcademicYear.Name = "lblAcademicYear";
            this.lblAcademicYear.Size = new System.Drawing.Size(75, 13);
            this.lblAcademicYear.TabIndex = 4;
            this.lblAcademicYear.Text = "Учебный год:";
            // 
            // cmbEducationalInstitutions
            // 
            this.cmbEducationalInstitutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationalInstitutions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEducationalInstitutions.FormattingEnabled = true;
            this.cmbEducationalInstitutions.Location = new System.Drawing.Point(122, 6);
            this.cmbEducationalInstitutions.Name = "cmbEducationalInstitutions";
            this.cmbEducationalInstitutions.Size = new System.Drawing.Size(263, 21);
            this.cmbEducationalInstitutions.TabIndex = 10;
            this.cmbEducationalInstitutions.TabStop = false;
            // 
            // lblEducationalInstitution
            // 
            this.lblEducationalInstitution.AutoSize = true;
            this.lblEducationalInstitution.Location = new System.Drawing.Point(6, 9);
            this.lblEducationalInstitution.Name = "lblEducationalInstitution";
            this.lblEducationalInstitution.Size = new System.Drawing.Size(110, 13);
            this.lblEducationalInstitution.TabIndex = 6;
            this.lblEducationalInstitution.Text = "Учебное заведение:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExportYears);
            this.panel2.Controls.Add(this.btnExportExamYear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 535);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 31);
            this.panel2.TabIndex = 3;
            // 
            // btnExportYears
            // 
            this.btnExportYears.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportYears.Location = new System.Drawing.Point(180, 0);
            this.btnExportYears.Name = "btnExportYears";
            this.btnExportYears.Size = new System.Drawing.Size(205, 31);
            this.btnExportYears.TabIndex = 3;
            this.btnExportYears.Text = "Экспорт по годам";
            this.btnExportYears.UseVisualStyleBackColor = true;
            this.btnExportYears.Visible = false;
            this.btnExportYears.Click += new System.EventHandler(this.btnExportYears_Click);
            // 
            // btnExportExamYear
            // 
            this.btnExportExamYear.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExportExamYear.Location = new System.Drawing.Point(0, 0);
            this.btnExportExamYear.Name = "btnExportExamYear";
            this.btnExportExamYear.Size = new System.Drawing.Size(180, 31);
            this.btnExportExamYear.TabIndex = 2;
            this.btnExportExamYear.Text = "Экспорт Экзамен/год";
            this.btnExportExamYear.UseVisualStyleBackColor = true;
            this.btnExportExamYear.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ReportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportUC";
            this.Size = new System.Drawing.Size(1070, 569);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFilter)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPerfomances)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemoveEI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmblAcademicYears;
        private System.Windows.Forms.Label lblAcademicYear;
        private System.Windows.Forms.ComboBox cmbEducationalInstitutions;
        private System.Windows.Forms.Label lblEducationalInstitution;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExportYears;
        private System.Windows.Forms.Button btnExportExamYear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataPerfomances;
    }
}
