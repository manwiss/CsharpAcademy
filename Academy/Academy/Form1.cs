using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataLayer;
using Entity;
using DataWriter;

namespace Academy
{
    public partial class Form1 : Form
    {
        //remove poll and save to database from winforms
        //Winforms just read from database
        //Logika iškelta kitur
        private ComputerDetail computerDetail;
        private int CPU = 0;
        private int RAM = 0;
        private int HdSpace = 0;
        private int AvgDiskQueueLength = 0;
        private DateTime Time;
        private DataUpdater updater;





        public Form1()
        {
            InitializeComponent();

            
            updater=new DataUpdater();



            //Cleaning the chart and preparing chat series for CpuUsage,RamUsge, HdSpaceAvaiable, and AverageDiskQueueLength
            RamAndCpuUsageInfo.Series.Clear();
            HdSpaceChart.Series.Clear();
            HdSpaceChart.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            RamAndCpuUsageInfo.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            RamAndCpuUsageInfo.ChartAreas[0].AxisY.Maximum = 100;

            var CpuSeries = new Series();
            CpuSeries.ChartType = SeriesChartType.Line;
            CpuSeries.BorderWidth = 3;
            CpuSeries.Color = Color.Blue;
            CpuSeries.Name = "Cpu Usage %";

            RamAndCpuUsageInfo.Series.Add(CpuSeries);

            CpuSeries.XValueType = ChartValueType.DateTime;

            var RamSeries = new Series();
            RamSeries.ChartType = SeriesChartType.Line;
            RamSeries.BorderWidth = 3;
            RamSeries.Color = Color.Coral;
            RamSeries.Name = "Ram Usage %";
            RamAndCpuUsageInfo.Series.Add(RamSeries);

            var HdSpaceSeries = new Series();
            HdSpaceSeries.ChartType = SeriesChartType.Line;
            HdSpaceSeries.BorderWidth = 3;
            HdSpaceSeries.Color = Color.DarkRed;
            HdSpaceSeries.Name = "Available HD\n Space  (GB)";
            HdSpaceChart.Series.Add(HdSpaceSeries);



            var AverageDiskQueueLengthSeries = new Series();
            AverageDiskQueueLengthSeries.ChartType = SeriesChartType.Line;
            AverageDiskQueueLengthSeries.BorderWidth = 3;
            AverageDiskQueueLengthSeries.Color = Color.Chartreuse;
            AverageDiskQueueLengthSeries.Name = "DiskQueueLength";
            RamAndCpuUsageInfo.Series.Add(AverageDiskQueueLengthSeries);



        }



        private void button1_Click(object sender, EventArgs e)
        {

            //Uses the updater which collects the current computer data and saves it to database using entity
            updater.UpadatStaticeComputerData();
            computerDetail = updater.getLastUpdatedComputerDetail();


            //Displays static data of the current computer
            DisplayStaticData(computerDetail);
            

            var clock = new Clock();
            clock.UpdateFinished += GetCurrentTime;
            clock.UpdateFinished += DisplayDynamicData;
            clock.Start();



        }

        //Displays static data on WinForms
        private void DisplayStaticData(ComputerDetail computerDetail)
        {
            ComputerNameTextBox.Text = computerDetail.Name;
            UserTextBox.Text = computerDetail.User;
            VideoCardTextBox.Text = computerDetail.VideoCard;
            IpTextBox.Text = computerDetail.Ip;
            CpuTextBox.Text = computerDetail.Cpu;
        }

        //Displays dynmaic data on TextBoxes and Charts
        private void DisplayDynamicData(object sender, EventArgs e)
        {

            updater.UpdateDynamicComputerData();
            var usageData = updater.getLastUpdatedComputerDetail().UsageDataCollection.Last();
            CpuUsageText.Text = usageData.CpuUsage.ToString();
            RamTextBox.Text = usageData.RamUsage.ToString();
            HardDiskSpaceTextBox.Text = usageData.AvailableDiskSpaceGb.ToString();
            AvgDiskQueueLengthTextBox.Text = usageData.AverageDiskQueueLength.ToString();


            HdSpace = usageData.AvailableDiskSpaceGb;
            RAM = usageData.RamUsage;
            CPU = usageData.CpuUsage;
            AvgDiskQueueLength = usageData.AverageDiskQueueLength;

            //Calls the methods for every series to be updated
            RamSeries();
            CpuSeries();
            HdSeries();
            DiskQueueLengthSeries();



        }




        private void ComputerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetCurrentTime(object sender, EventArgs e )
        {
            Time = DateTime.Now.ToLocalTime();
        }



        private void RamSeries()
        {

            RamTextBox.Text = RAM.ToString();
            RamAndCpuUsageInfo.Series[1].Points.AddXY(Time.ToString("HH:mm:ss"), RAM);
            while (RamAndCpuUsageInfo.Series[1].Points.Count > 9)
            {
                RamAndCpuUsageInfo.Series[1].Points.RemoveAt(0);
            }
         



        }

        private void CpuSeries()
        {

            CpuUsageText.Text = CPU.ToString();
            RamAndCpuUsageInfo.Series[0].Points.AddXY(Time.ToString("HH:mm:ss"), CPU);
            while (RamAndCpuUsageInfo.Series[0].Points.Count > 9)
            {
                RamAndCpuUsageInfo.Series[0].Points.RemoveAt(0);
            }


        }
        private void HdSeries()
        {
            HardDiskSpaceTextBox.Text = HdSpace.ToString();

            HdSpaceChart.Series[0].Points.AddXY(Time.ToString("HH:mm:ss"), HdSpace);
            while (HdSpaceChart.Series[0].Points.Count > 9)
            {
                HdSpaceChart.Series[0].Points.RemoveAt(0);
            }


        }

        private void DiskQueueLengthSeries()

        {

            RamAndCpuUsageInfo.Series[2].Points.AddXY(Time.ToString("HH:mm:ss"), AvgDiskQueueLength);
            AvgDiskQueueLengthTextBox.Text = AvgDiskQueueLength.ToString();
            while (RamAndCpuUsageInfo.Series[2].Points.Count > 9)
            {
                RamAndCpuUsageInfo.Series[2].Points.RemoveAt(0);
            }

        }




        private void RamAndCpuUsageInfo_Click(object sender, EventArgs e)
        {


        }


    }
}
