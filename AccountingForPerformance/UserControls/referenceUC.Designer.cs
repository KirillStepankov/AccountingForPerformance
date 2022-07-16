namespace AccountingForPerformance.UserControls
{
    partial class referenceUC
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataEI = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveEI = new System.Windows.Forms.Button();
            this.btnEditEI = new System.Windows.Forms.Button();
            this.btnAddEI = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataYear = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddAY = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataSubjects = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataClasses = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataLevelAssessments = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEI)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataYear)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubjects)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClasses)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLevelAssessments)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1218, 657);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataEI);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1210, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Учебные заведения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataEI
            // 
            this.dataEI.AllowUserToAddRows = false;
            this.dataEI.AllowUserToDeleteRows = false;
            this.dataEI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataEI.BackgroundColor = System.Drawing.Color.White;
            this.dataEI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEI.Location = new System.Drawing.Point(3, 3);
            this.dataEI.Name = "dataEI";
            this.dataEI.ReadOnly = true;
            this.dataEI.RowHeadersVisible = false;
            this.dataEI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEI.Size = new System.Drawing.Size(1204, 577);
            this.dataEI.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveEI);
            this.panel1.Controls.Add(this.btnEditEI);
            this.panel1.Controls.Add(this.btnAddEI);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 580);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnRemoveEI
            // 
            this.btnRemoveEI.Location = new System.Drawing.Point(215, 10);
            this.btnRemoveEI.Name = "btnRemoveEI";
            this.btnRemoveEI.Size = new System.Drawing.Size(100, 25);
            this.btnRemoveEI.TabIndex = 0;
            this.btnRemoveEI.Text = "Удалить";
            this.btnRemoveEI.UseVisualStyleBackColor = true;
            this.btnRemoveEI.Click += new System.EventHandler(this.btnRemoveEI_Click);
            // 
            // btnEditEI
            // 
            this.btnEditEI.Location = new System.Drawing.Point(109, 10);
            this.btnEditEI.Name = "btnEditEI";
            this.btnEditEI.Size = new System.Drawing.Size(100, 25);
            this.btnEditEI.TabIndex = 0;
            this.btnEditEI.Text = "Редактировать";
            this.btnEditEI.UseVisualStyleBackColor = true;
            this.btnEditEI.Click += new System.EventHandler(this.btnEditEI_Click);
            // 
            // btnAddEI
            // 
            this.btnAddEI.Location = new System.Drawing.Point(3, 10);
            this.btnAddEI.Name = "btnAddEI";
            this.btnAddEI.Size = new System.Drawing.Size(100, 25);
            this.btnAddEI.TabIndex = 0;
            this.btnAddEI.Text = "Добавить";
            this.btnAddEI.UseVisualStyleBackColor = true;
            this.btnAddEI.Click += new System.EventHandler(this.btnAddEI_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataYear);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1210, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Учебные года";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataYear
            // 
            this.dataYear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataYear.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataYear.BackgroundColor = System.Drawing.Color.White;
            this.dataYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataYear.Location = new System.Drawing.Point(3, 3);
            this.dataYear.Name = "dataYear";
            this.dataYear.RowHeadersVisible = false;
            this.dataYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataYear.Size = new System.Drawing.Size(1204, 577);
            this.dataYear.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddAY);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1204, 48);
            this.panel2.TabIndex = 2;
            // 
            // btnAddAY
            // 
            this.btnAddAY.Location = new System.Drawing.Point(18, 12);
            this.btnAddAY.Name = "btnAddAY";
            this.btnAddAY.Size = new System.Drawing.Size(250, 25);
            this.btnAddAY.TabIndex = 0;
            this.btnAddAY.Text = "Добавить текущий учебный год";
            this.btnAddAY.UseVisualStyleBackColor = true;
            this.btnAddAY.Click += new System.EventHandler(this.btnAddAY_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataSubjects);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1210, 631);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Предметы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataSubjects
            // 
            this.dataSubjects.AllowUserToAddRows = false;
            this.dataSubjects.AllowUserToDeleteRows = false;
            this.dataSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dataSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSubjects.Location = new System.Drawing.Point(3, 3);
            this.dataSubjects.MultiSelect = false;
            this.dataSubjects.Name = "dataSubjects";
            this.dataSubjects.ReadOnly = true;
            this.dataSubjects.RowHeadersVisible = false;
            this.dataSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSubjects.Size = new System.Drawing.Size(1204, 577);
            this.dataSubjects.TabIndex = 3;
            this.dataSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSubjects_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 580);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1204, 48);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(247, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(710, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Для редактирования данных этого справочника необходимом обратиться к администарто" +
    "ру!!!";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataClasses);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1210, 631);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Класы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataClasses
            // 
            this.dataClasses.AllowUserToAddRows = false;
            this.dataClasses.AllowUserToDeleteRows = false;
            this.dataClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClasses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataClasses.BackgroundColor = System.Drawing.Color.White;
            this.dataClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataClasses.Location = new System.Drawing.Point(3, 3);
            this.dataClasses.MultiSelect = false;
            this.dataClasses.Name = "dataClasses";
            this.dataClasses.ReadOnly = true;
            this.dataClasses.RowHeadersVisible = false;
            this.dataClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClasses.Size = new System.Drawing.Size(1204, 577);
            this.dataClasses.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 580);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1204, 48);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(247, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(710, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Для редактирования данных этого справочника необходимом обратиться к администарто" +
    "ру!!!";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataLevelAssessments);
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1210, 631);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Уровень оценок";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataLevelAssessments
            // 
            this.dataLevelAssessments.AllowUserToAddRows = false;
            this.dataLevelAssessments.AllowUserToDeleteRows = false;
            this.dataLevelAssessments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLevelAssessments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLevelAssessments.BackgroundColor = System.Drawing.Color.White;
            this.dataLevelAssessments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLevelAssessments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLevelAssessments.Location = new System.Drawing.Point(3, 3);
            this.dataLevelAssessments.MultiSelect = false;
            this.dataLevelAssessments.Name = "dataLevelAssessments";
            this.dataLevelAssessments.ReadOnly = true;
            this.dataLevelAssessments.RowHeadersVisible = false;
            this.dataLevelAssessments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLevelAssessments.Size = new System.Drawing.Size(1204, 577);
            this.dataLevelAssessments.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 580);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1204, 48);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(247, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для редактирования данных этого справочника необходимом обратиться к администарто" +
    "ру!!!";
            // 
            // referenceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "referenceUC";
            this.Size = new System.Drawing.Size(1218, 657);
            this.Load += new System.EventHandler(this.referenceUC_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEI)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataYear)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSubjects)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataClasses)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLevelAssessments)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataEI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataYear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataSubjects;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataClasses;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataLevelAssessments;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveEI;
        private System.Windows.Forms.Button btnEditEI;
        private System.Windows.Forms.Button btnAddEI;
        private System.Windows.Forms.Button btnAddAY;
    }
}
