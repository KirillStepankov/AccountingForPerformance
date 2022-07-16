namespace AccountingForPerformance.UserControls
{
    partial class ExamYearChartUC
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypeAssessments = new System.Windows.Forms.ComboBox();
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartAverage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartQuality = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbTypeAssessments);
            this.panel1.Controls.Add(this.cmbClasses);
            this.panel1.Controls.Add(this.cmbYears);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 36);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(947, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Печать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(633, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(177, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Сформировать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Период";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Класс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Учебный год";
            // 
            // cmbTypeAssessments
            // 
            this.cmbTypeAssessments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeAssessments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTypeAssessments.FormattingEnabled = true;
            this.cmbTypeAssessments.Location = new System.Drawing.Point(60, 6);
            this.cmbTypeAssessments.Name = "cmbTypeAssessments";
            this.cmbTypeAssessments.Size = new System.Drawing.Size(138, 21);
            this.cmbTypeAssessments.TabIndex = 0;
            // 
            // cmbClasses
            // 
            this.cmbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(460, 6);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(167, 21);
            this.cmbClasses.TabIndex = 0;
            // 
            // cmbYears
            // 
            this.cmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYears.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Location = new System.Drawing.Point(284, 6);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(125, 21);
            this.cmbYears.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartAverage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartQuality, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1127, 644);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chartAverage
            // 
            this.chartAverage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chartAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartAverage.Location = new System.Drawing.Point(566, 3);
            this.chartAverage.Name = "chartAverage";
            this.chartAverage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chartAverage.Size = new System.Drawing.Size(558, 638);
            this.chartAverage.TabIndex = 3;
            title1.Name = "Title1";
            title2.Name = "Title2";
            this.chartAverage.Titles.Add(title1);
            this.chartAverage.Titles.Add(title2);
            // 
            // chartQuality
            // 
            this.chartQuality.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chartQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartQuality.Location = new System.Drawing.Point(3, 3);
            this.chartQuality.Name = "chartQuality";
            this.chartQuality.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.Name = "Series1";
            this.chartQuality.Series.Add(series1);
            this.chartQuality.Size = new System.Drawing.Size(557, 638);
            this.chartQuality.TabIndex = 2;
            title3.Name = "Title1";
            title4.Name = "Title2";
            this.chartQuality.Titles.Add(title3);
            this.chartQuality.Titles.Add(title4);
            // 
            // ExamYearChartUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ExamYearChartUC";
            this.Size = new System.Drawing.Size(1127, 680);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTypeAssessments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAverage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuality;
    }
}
