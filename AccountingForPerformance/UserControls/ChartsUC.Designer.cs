namespace AccountingForPerformance.UserControls
{
    partial class ChartsUC
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
            this.tabChart = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.examYearChartUC1 = new AccountingForPerformance.UserControls.ExamYearChartUC();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.quarterChartUC1 = new AccountingForPerformance.UserControls.Charts.QuarterChartUC();
            this.tabChart.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.tabPage1);
            this.tabChart.Controls.Add(this.tabPage2);
            this.tabChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChart.Location = new System.Drawing.Point(0, 0);
            this.tabChart.Name = "tabChart";
            this.tabChart.SelectedIndex = 0;
            this.tabChart.Size = new System.Drawing.Size(1170, 650);
            this.tabChart.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.examYearChartUC1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Экзамен/Год";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // examYearChartUC1
            // 
            this.examYearChartUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.examYearChartUC1.Location = new System.Drawing.Point(3, 3);
            this.examYearChartUC1.Name = "examYearChartUC1";
            this.examYearChartUC1.Size = new System.Drawing.Size(1156, 618);
            this.examYearChartUC1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.quarterChartUC1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "По школам за период";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // quarterChartUC1
            // 
            this.quarterChartUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quarterChartUC1.Location = new System.Drawing.Point(3, 3);
            this.quarterChartUC1.Name = "quarterChartUC1";
            this.quarterChartUC1.Size = new System.Drawing.Size(1156, 618);
            this.quarterChartUC1.TabIndex = 0;
            // 
            // ChartsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabChart);
            this.Name = "ChartsUC";
            this.Size = new System.Drawing.Size(1170, 650);
            this.Load += new System.EventHandler(this.ChartsUC_Load);
            this.tabChart.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabChart;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ExamYearChartUC examYearChartUC1;
        private Charts.QuarterChartUC quarterChartUC1;
    }
}
