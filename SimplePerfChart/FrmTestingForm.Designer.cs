namespace SimplePerfChart
{
    partial class FrmTestingForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            SpPerfChart.ChartPen chartPen1 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen2 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen3 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen4 = new SpPerfChart.ChartPen();
            this.grpBxChart = new System.Windows.Forms.GroupBox();
            this.perfChart = new SpPerfChart.PerfChart();
            this.grpBxRandVal = new System.Windows.Forms.GroupBox();
            this.chkBxTimerEnabled = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numUpDnToInterval = new System.Windows.Forms.NumericUpDown();
            this.numUpDnFromInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bgWrkTimer = new System.ComponentModel.BackgroundWorker();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBxChart.SuspendLayout();
            this.grpBxRandVal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnToInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFromInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxChart
            // 
            this.grpBxChart.Controls.Add(this.perfChart);
            this.grpBxChart.Location = new System.Drawing.Point(16, 15);
            this.grpBxChart.Margin = new System.Windows.Forms.Padding(4);
            this.grpBxChart.Name = "grpBxChart";
            this.grpBxChart.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpBxChart.Size = new System.Drawing.Size(345, 174);
            this.grpBxChart.TabIndex = 0;
            this.grpBxChart.TabStop = false;
            this.grpBxChart.Text = "Chart";
            // 
            // perfChart
            // 
            this.perfChart.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.perfChart.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.perfChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.perfChart.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.perfChart.Location = new System.Drawing.Point(8, 22);
            this.perfChart.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.perfChart.Name = "perfChart";
            this.perfChart.PerfChartStyle.AntiAliasing = true;
            chartPen1.Color = System.Drawing.Color.LightGreen;
            chartPen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            chartPen1.Width = 1F;
            this.perfChart.PerfChartStyle.AvgLinePen = chartPen1;
            this.perfChart.PerfChartStyle.BackgroundColorBottom = System.Drawing.Color.DarkOliveGreen;
            this.perfChart.PerfChartStyle.BackgroundColorTop = System.Drawing.Color.YellowGreen;
            chartPen2.Color = System.Drawing.Color.Gold;
            chartPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen2.Width = 1F;
            this.perfChart.PerfChartStyle.ChartLinePen = chartPen2;
            chartPen3.Color = System.Drawing.Color.DarkOliveGreen;
            chartPen3.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            chartPen3.Width = 1F;
            this.perfChart.PerfChartStyle.HorizontalGridPen = chartPen3;
            this.perfChart.PerfChartStyle.ShowAverageLine = true;
            this.perfChart.PerfChartStyle.ShowHorizontalGridLines = true;
            this.perfChart.PerfChartStyle.ShowVerticalGridLines = true;
            chartPen4.Color = System.Drawing.Color.DarkOliveGreen;
            chartPen4.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            chartPen4.Width = 1F;
            this.perfChart.PerfChartStyle.VerticalGridPen = chartPen4;
            this.perfChart.ScaleMode = SpPerfChart.ScaleMode.Relative;
            this.perfChart.Size = new System.Drawing.Size(329, 145);
            this.perfChart.TabIndex = 0;
            this.perfChart.TimerInterval = 100;
            this.perfChart.TimerMode = SpPerfChart.TimerMode.Disabled;
            this.perfChart.Load += new System.EventHandler(this.perfChart_Load);
            // 
            // grpBxRandVal
            // 
            this.grpBxRandVal.Controls.Add(this.chkBxTimerEnabled);
            this.grpBxRandVal.Controls.Add(this.label5);
            this.grpBxRandVal.Controls.Add(this.numUpDnToInterval);
            this.grpBxRandVal.Controls.Add(this.numUpDnFromInterval);
            this.grpBxRandVal.Controls.Add(this.label3);
            this.grpBxRandVal.Controls.Add(this.label2);
            this.grpBxRandVal.Location = new System.Drawing.Point(16, 196);
            this.grpBxRandVal.Margin = new System.Windows.Forms.Padding(4);
            this.grpBxRandVal.Name = "grpBxRandVal";
            this.grpBxRandVal.Padding = new System.Windows.Forms.Padding(4);
            this.grpBxRandVal.Size = new System.Drawing.Size(345, 111);
            this.grpBxRandVal.TabIndex = 1;
            this.grpBxRandVal.TabStop = false;
            this.grpBxRandVal.Text = "Value Generator Timer";
            // 
            // chkBxTimerEnabled
            // 
            this.chkBxTimerEnabled.AutoSize = true;
            this.chkBxTimerEnabled.Location = new System.Drawing.Point(21, 59);
            this.chkBxTimerEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.chkBxTimerEnabled.Name = "chkBxTimerEnabled";
            this.chkBxTimerEnabled.Size = new System.Drawing.Size(122, 21);
            this.chkBxTimerEnabled.TabIndex = 7;
            this.chkBxTimerEnabled.Text = "Timer Enabled";
            this.chkBxTimerEnabled.UseVisualStyleBackColor = true;
            this.chkBxTimerEnabled.CheckedChanged += new System.EventHandler(this.chkBxTimerEnabled_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "ms";
            // 
            // numUpDnToInterval
            // 
            this.numUpDnToInterval.Location = new System.Drawing.Point(185, 27);
            this.numUpDnToInterval.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDnToInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDnToInterval.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnToInterval.Name = "numUpDnToInterval";
            this.numUpDnToInterval.Size = new System.Drawing.Size(87, 22);
            this.numUpDnToInterval.TabIndex = 5;
            this.numUpDnToInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numUpDnFromInterval
            // 
            this.numUpDnFromInterval.Location = new System.Drawing.Point(61, 27);
            this.numUpDnFromInterval.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDnFromInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDnFromInterval.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnFromInterval.Name = "numUpDnFromInterval";
            this.numUpDnFromInterval.Size = new System.Drawing.Size(87, 22);
            this.numUpDnFromInterval.TabIndex = 3;
            this.numUpDnFromInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "from";
            // 
            // bgWrkTimer
            // 
            this.bgWrkTimer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWrkTimer_DoWork);
            this.bgWrkTimer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWrkTimer_RunWorkerCompleted);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(615, 405);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 28);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(512, 405);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 471);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpBxRandVal);
            this.Controls.Add(this.grpBxChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmTestingForm";
            this.Text = "PerfChart Testing Application";
            this.grpBxChart.ResumeLayout(false);
            this.grpBxRandVal.ResumeLayout(false);
            this.grpBxRandVal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnToInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFromInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxChart;
        private SpPerfChart.PerfChart perfChart;
        private System.Windows.Forms.GroupBox grpBxRandVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUpDnToInterval;
        private System.Windows.Forms.NumericUpDown numUpDnFromInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBxTimerEnabled;
        private System.ComponentModel.BackgroundWorker bgWrkTimer;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClear;
    }
}