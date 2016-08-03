using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataLayer;

namespace Academy
{
    public partial class Form1 : Form
    {
        private FullDataManager manager;
        private ComputerSummary summary;
        private int timer = 0;
        private int CPU = 0;
        private int RAM = 0;
        private int HdSpace = 0;
        private DateTime time;
        




        public Form1()
        {
            InitializeComponent();
           


            time = new DateTime();
            timer1.Interval = 1000;
            RamAndCpuUsageInfo.Series.Clear();
            HdSpaceChart.Series.Clear();
            HdSpaceChart.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            RamAndCpuUsageInfo.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            RamAndCpuUsageInfo.ChartAreas[0].AxisY.Maximum = 100;


            var CpuSeries = new Series();
            CpuSeries.ChartType = SeriesChartType.Line;
            CpuSeries.BorderWidth = 3;
            CpuSeries.Color = Color.Blue;
            CpuSeries.Name = "Cpu Usage";
            
            RamAndCpuUsageInfo.Series.Add(CpuSeries);

            CpuSeries.XValueType = ChartValueType.DateTime;

            var RamSeries = new Series();
            RamSeries.ChartType = SeriesChartType.Line;
            RamSeries.BorderWidth = 3;
            RamSeries.Color = Color.Coral;
            RamSeries.Name = "Ram Usage";
            RamAndCpuUsageInfo.Series.Add(RamSeries);

            var HdSpaceSeries = new Series();
            HdSpaceSeries.ChartType = SeriesChartType.Line;
            HdSpaceSeries.BorderWidth = 3;
            HdSpaceSeries.Color = Color.Chartreuse;
            HdSpaceSeries.Name = "Available HD space";
            HdSpaceChart.Series.Add(HdSpaceSeries);



            //chart filling logic in some other class, some events to allow the timer to spin between some i



        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            manager =new FullDataManager();
            summary = manager.GetComputerSummary();
            timer1.Enabled = true;
            ComputerName.Text = summary.Name;
            User.Text = summary.User;
            Cpu.Text = summary.Cpu;
            Ram.Text = summary.RamUsage.ToString() + "%" ;
            VideoCard.Text = summary.VideoCard;
            Ip.Text = summary.Ip.ToString();
            CpuUsageText.Text = summary.CpuUsage.ToString() + "%";
            HardDiskSpaceTextBox.Text = summary.AvailableDiskSpaceGb + "GB";
            AvgDiskQueueLengthTextBox.Text = summary.AverageDiskQueueLength.ToString();













        }

        

        private void ComputerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
            CPU = Convert.ToInt32(manager.GetMetric(ComputerMetrics.CpuUsage));
            RAM = Convert.ToInt32(manager.GetMetric(ComputerMetrics.RamUsage));
            HdSpace = Convert.ToInt32(manager.GetMetric(ComputerMetrics.AvailableDiskSpace));
            
            Ram.Text = Convert.ToInt32(manager.GetMetric(ComputerMetrics.RamUsage)).ToString();
            CpuUsageText.Text = CPU.ToString();

            HdSpaceChart.Series[0].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), HdSpace);
            RamAndCpuUsageInfo.Series[0].Points.AddXY( DateTime.Now.ToString("hh:mm:ss"), CPU);
            RamAndCpuUsageInfo.Series[1].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), RAM);

            while (RamAndCpuUsageInfo.Series[0].Points.Count > 8)
            {
                RamAndCpuUsageInfo.Series[0].Points.RemoveAt(0);
            }

            while (RamAndCpuUsageInfo.Series[1].Points.Count > 8)
            {
                RamAndCpuUsageInfo.Series[1].Points.RemoveAt(0);
            }

            while (HdSpaceChart.Series[0].Points.Count > 8)
            {
                HdSpaceChart.Series[0].Points.RemoveAt(0);
            }


            //bla bla bla 



        }

        private void RamAndCpuUsageInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
