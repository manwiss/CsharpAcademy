namespace Academy
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DisplayText = new System.Windows.Forms.Button();
            this.ComputerName = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Cpu = new System.Windows.Forms.TextBox();
            this.Ram = new System.Windows.Forms.TextBox();
            this.VideoCard = new System.Windows.Forms.TextBox();
            this.Ip = new System.Windows.Forms.TextBox();
            this.ComputerLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.CpuLabel = new System.Windows.Forms.Label();
            this.RamLabel = new System.Windows.Forms.Label();
            this.VideoCardLabel = new System.Windows.Forms.Label();
            this.IpLabel = new System.Windows.Forms.Label();
            this.RamAndCpuUsageInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CpuUsageText = new System.Windows.Forms.TextBox();
            this.CpuUsageLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HardDiskSpaceLabel = new System.Windows.Forms.Label();
            this.HardDiskSpaceTextBox = new System.Windows.Forms.TextBox();
            this.AvgDiskQueueLengthTextBox = new System.Windows.Forms.TextBox();
            this.AvgDiskQueueLengthLabel = new System.Windows.Forms.Label();
            this.HdSpaceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.RamAndCpuUsageInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HdSpaceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayText
            // 
            this.DisplayText.Location = new System.Drawing.Point(64, 55);
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(104, 39);
            this.DisplayText.TabIndex = 0;
            this.DisplayText.Text = "Display";
            this.DisplayText.UseVisualStyleBackColor = true;
            this.DisplayText.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComputerName
            // 
            this.ComputerName.Location = new System.Drawing.Point(420, 64);
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Size = new System.Drawing.Size(236, 22);
            this.ComputerName.TabIndex = 1;
            this.ComputerName.TextChanged += new System.EventHandler(this.ComputerName_TextChanged);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(420, 109);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(236, 22);
            this.User.TabIndex = 2;
            // 
            // Cpu
            // 
            this.Cpu.Location = new System.Drawing.Point(420, 155);
            this.Cpu.Name = "Cpu";
            this.Cpu.Size = new System.Drawing.Size(236, 22);
            this.Cpu.TabIndex = 3;
            // 
            // Ram
            // 
            this.Ram.Location = new System.Drawing.Point(420, 284);
            this.Ram.Name = "Ram";
            this.Ram.Size = new System.Drawing.Size(236, 22);
            this.Ram.TabIndex = 4;
            // 
            // VideoCard
            // 
            this.VideoCard.Location = new System.Drawing.Point(420, 198);
            this.VideoCard.Name = "VideoCard";
            this.VideoCard.Size = new System.Drawing.Size(236, 22);
            this.VideoCard.TabIndex = 5;
            // 
            // Ip
            // 
            this.Ip.Location = new System.Drawing.Point(420, 238);
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(236, 22);
            this.Ip.TabIndex = 6;
            // 
            // ComputerLabel
            // 
            this.ComputerLabel.AutoSize = true;
            this.ComputerLabel.Location = new System.Drawing.Point(241, 69);
            this.ComputerLabel.Name = "ComputerLabel";
            this.ComputerLabel.Size = new System.Drawing.Size(106, 17);
            this.ComputerLabel.TabIndex = 7;
            this.ComputerLabel.Text = "ComputerName";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(241, 114);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(75, 17);
            this.UserLabel.TabIndex = 8;
            this.UserLabel.Text = "UserName";
            // 
            // CpuLabel
            // 
            this.CpuLabel.AutoSize = true;
            this.CpuLabel.Location = new System.Drawing.Point(241, 157);
            this.CpuLabel.Name = "CpuLabel";
            this.CpuLabel.Size = new System.Drawing.Size(70, 17);
            this.CpuLabel.TabIndex = 9;
            this.CpuLabel.Text = "CpuName";
            // 
            // RamLabel
            // 
            this.RamLabel.AutoSize = true;
            this.RamLabel.Location = new System.Drawing.Point(242, 289);
            this.RamLabel.Name = "RamLabel";
            this.RamLabel.Size = new System.Drawing.Size(78, 17);
            this.RamLabel.TabIndex = 10;
            this.RamLabel.Text = "RamUsage";
            // 
            // VideoCardLabel
            // 
            this.VideoCardLabel.AutoSize = true;
            this.VideoCardLabel.Location = new System.Drawing.Point(242, 200);
            this.VideoCardLabel.Name = "VideoCardLabel";
            this.VideoCardLabel.Size = new System.Drawing.Size(74, 17);
            this.VideoCardLabel.TabIndex = 11;
            this.VideoCardLabel.Text = "VideoCard";
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(242, 245);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(20, 17);
            this.IpLabel.TabIndex = 12;
            this.IpLabel.Text = "IP";
            // 
            // RamAndCpuUsageInfo
            // 
            chartArea1.Name = "ChartArea1";
            this.RamAndCpuUsageInfo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.RamAndCpuUsageInfo.Legends.Add(legend1);
            this.RamAndCpuUsageInfo.Location = new System.Drawing.Point(678, 55);
            this.RamAndCpuUsageInfo.Name = "RamAndCpuUsageInfo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.RamAndCpuUsageInfo.Series.Add(series1);
            this.RamAndCpuUsageInfo.Size = new System.Drawing.Size(394, 262);
            this.RamAndCpuUsageInfo.TabIndex = 13;
            this.RamAndCpuUsageInfo.Text = "chart1";
            this.RamAndCpuUsageInfo.Click += new System.EventHandler(this.RamAndCpuUsageInfo_Click);
            // 
            // CpuUsageText
            // 
            this.CpuUsageText.Location = new System.Drawing.Point(420, 333);
            this.CpuUsageText.Name = "CpuUsageText";
            this.CpuUsageText.Size = new System.Drawing.Size(236, 22);
            this.CpuUsageText.TabIndex = 15;
            // 
            // CpuUsageLabel
            // 
            this.CpuUsageLabel.AutoSize = true;
            this.CpuUsageLabel.Location = new System.Drawing.Point(241, 338);
            this.CpuUsageLabel.Name = "CpuUsageLabel";
            this.CpuUsageLabel.Size = new System.Drawing.Size(74, 17);
            this.CpuUsageLabel.TabIndex = 16;
            this.CpuUsageLabel.Text = "CpuUsage";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HardDiskSpaceLabel
            // 
            this.HardDiskSpaceLabel.AutoSize = true;
            this.HardDiskSpaceLabel.Location = new System.Drawing.Point(241, 382);
            this.HardDiskSpaceLabel.Name = "HardDiskSpaceLabel";
            this.HardDiskSpaceLabel.Size = new System.Drawing.Size(131, 17);
            this.HardDiskSpaceLabel.TabIndex = 17;
            this.HardDiskSpaceLabel.Text = "Available HD space";
            // 
            // HardDiskSpaceTextBox
            // 
            this.HardDiskSpaceTextBox.Location = new System.Drawing.Point(420, 379);
            this.HardDiskSpaceTextBox.Name = "HardDiskSpaceTextBox";
            this.HardDiskSpaceTextBox.Size = new System.Drawing.Size(236, 22);
            this.HardDiskSpaceTextBox.TabIndex = 18;
            // 
            // AvgDiskQueueLengthTextBox
            // 
            this.AvgDiskQueueLengthTextBox.Location = new System.Drawing.Point(420, 421);
            this.AvgDiskQueueLengthTextBox.Name = "AvgDiskQueueLengthTextBox";
            this.AvgDiskQueueLengthTextBox.Size = new System.Drawing.Size(236, 22);
            this.AvgDiskQueueLengthTextBox.TabIndex = 19;
            // 
            // AvgDiskQueueLengthLabel
            // 
            this.AvgDiskQueueLengthLabel.AutoSize = true;
            this.AvgDiskQueueLengthLabel.Location = new System.Drawing.Point(241, 424);
            this.AvgDiskQueueLengthLabel.Name = "AvgDiskQueueLengthLabel";
            this.AvgDiskQueueLengthLabel.Size = new System.Drawing.Size(162, 17);
            this.AvgDiskQueueLengthLabel.TabIndex = 20;
            this.AvgDiskQueueLengthLabel.Text = "Avg. Disk Queue Length";
            // 
            // HdSpaceChart
            // 
            chartArea2.Name = "ChartArea1";
            this.HdSpaceChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.HdSpaceChart.Legends.Add(legend2);
            this.HdSpaceChart.Location = new System.Drawing.Point(678, 338);
            this.HdSpaceChart.Name = "HdSpaceChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.HdSpaceChart.Series.Add(series2);
            this.HdSpaceChart.Size = new System.Drawing.Size(394, 295);
            this.HdSpaceChart.TabIndex = 21;
            this.HdSpaceChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 680);
            this.Controls.Add(this.HdSpaceChart);
            this.Controls.Add(this.AvgDiskQueueLengthLabel);
            this.Controls.Add(this.AvgDiskQueueLengthTextBox);
            this.Controls.Add(this.HardDiskSpaceTextBox);
            this.Controls.Add(this.HardDiskSpaceLabel);
            this.Controls.Add(this.CpuUsageLabel);
            this.Controls.Add(this.CpuUsageText);
            this.Controls.Add(this.RamAndCpuUsageInfo);
            this.Controls.Add(this.IpLabel);
            this.Controls.Add(this.VideoCardLabel);
            this.Controls.Add(this.RamLabel);
            this.Controls.Add(this.CpuLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.ComputerLabel);
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.VideoCard);
            this.Controls.Add(this.Ram);
            this.Controls.Add(this.Cpu);
            this.Controls.Add(this.User);
            this.Controls.Add(this.ComputerName);
            this.Controls.Add(this.DisplayText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RamAndCpuUsageInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HdSpaceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayText;
        private System.Windows.Forms.TextBox ComputerName;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Cpu;
        private System.Windows.Forms.TextBox Ram;
        private System.Windows.Forms.TextBox VideoCard;
        private System.Windows.Forms.TextBox Ip;
        private System.Windows.Forms.Label ComputerLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label CpuLabel;
        private System.Windows.Forms.Label RamLabel;
        private System.Windows.Forms.Label VideoCardLabel;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart RamAndCpuUsageInfo;
        private System.Windows.Forms.TextBox CpuUsageText;
        private System.Windows.Forms.Label CpuUsageLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label HardDiskSpaceLabel;
        private System.Windows.Forms.TextBox HardDiskSpaceTextBox;
        private System.Windows.Forms.TextBox AvgDiskQueueLengthTextBox;
        private System.Windows.Forms.Label AvgDiskQueueLengthLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart HdSpaceChart;
    }
}

