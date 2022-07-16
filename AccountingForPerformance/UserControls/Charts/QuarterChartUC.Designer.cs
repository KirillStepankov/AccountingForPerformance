namespace AccountingForPerformance.UserControls.Charts
{
    partial class QuarterChartUC
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEducationalInstitutions = new System.Windows.Forms.ComboBox();
            this.lblEducationalInstitution = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chartQuarter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuarter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEducationalInstitutions);
            this.panel1.Controls.Add(this.lblEducationalInstitution);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbClasses);
            this.panel1.Controls.Add(this.cmbYears);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 36);
            this.panel1.TabIndex = 2;
            // 
            // cmbEducationalInstitutions
            // 
            this.cmbEducationalInstitutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationalInstitutions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEducationalInstitutions.FormattingEnabled = true;
            this.cmbEducationalInstitutions.Location = new System.Drawing.Point(124, 6);
            this.cmbEducationalInstitutions.Name = "cmbEducationalInstitutions";
            this.cmbEducationalInstitutions.Size = new System.Drawing.Size(263, 21);
            this.cmbEducationalInstitutions.TabIndex = 12;
            this.cmbEducationalInstitutions.TabStop = false;
            // 
            // lblEducationalInstitution
            // 
            this.lblEducationalInstitution.AutoSize = true;
            this.lblEducationalInstitution.Location = new System.Drawing.Point(8, 9);
            this.lblEducationalInstitution.Name = "lblEducationalInstitution";
            this.lblEducationalInstitution.Size = new System.Drawing.Size(110, 13);
            this.lblEducationalInstitution.TabIndex = 11;
            this.lblEducationalInstitution.Text = "Учебное заведение:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1058, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(825, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(154, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Сформировать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Класс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Учебный год";
            // 
            // cmbClasses
            // 
            this.cmbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(652, 6);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(167, 21);
            this.cmbClasses.TabIndex = 0;
            // 
            // cmbYears
            // 
            this.cmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYears.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Location = new System.Drawing.Point(476, 6);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(125, 21);
            this.cmbYears.TabIndex = 0;
            // 
            // chartQuarter
            // 
            this.chartQuarter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chartQuarter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartQuarter.Location = new System.Drawing.Point(0, 36);
            this.chartQuarter.Name = "chartQuarter";
            this.chartQuarter.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.Name = "Series1";
            this.chartQuarter.Series.Add(series1);
            this.chartQuarter.Size = new System.Drawing.Size(1216, 628);
            this.chartQuarter.TabIndex = 3;
            title1.Name = "Title1";
            title2.Name = "Title2";
            this.chartQuarter.Titles.Add(title1);
            this.chartQuarter.Titles.Add(title2);
            // 
            // QuarterChartUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartQuarter);
            this.Controls.Add(this.panel1);
            this.Name = "QuarterChartUC";
            this.Size = new System.Drawing.Size(1216, 664);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuarter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuarter;
        private System.Windows.Forms.ComboBox cmbEducationalInstitutions;
        private System.Windows.Forms.Label lblEducationalInstitution;
    }
}
