using System;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Entity;

namespace DataWriter
{
    public class DataUpdater

    {
        private ComputerDetail computerDetail; // the computer which we will track for dynamicDataChanges
        private MetricsContext context;

        public DataUpdater()
        {
            context=new MetricsContext();
        }


        //Updates static computer data to database
        public void UpadatStaticeComputerData()
        {
            
            context.Database.EnsureCreated();
            bool t = false; // Is the computer already in the list
            var manager = new FullDataManager();
            var summary = manager.GetComputerSummary();
            context = new MetricsContext();




            computerDetail = new ComputerDetail();
            computerDetail.Cpu = summary.Cpu;
            computerDetail.Ip = summary.Ip.ToString();
            computerDetail.Name = summary.Name;
            computerDetail.Ram = summary.Ram;
            computerDetail.VideoCard = summary.VideoCard;
            computerDetail.User = summary.User;

            //Checks if computer like this already exists in the databae, if it doesnt, it creates a new one
            foreach (var computerD in context.ComputerDetails)
            {
                if (computerD.Name == computerDetail.Name)
                {
                    t = true;
                    computerDetail = computerD; //

                }
            }

            if (!t)
            {

                context.Add(computerDetail);
                
            }


        }

        public void UpdateDynamicComputerData()
        {

            var usageData = new UsageData();
            var manager = new FullDataManager();
            usageData.AvailableDiskSpaceGb = Int32.Parse(manager.GetMetric(ComputerMetrics.AvailableDiskSpace));
            usageData.AverageDiskQueueLength = Int32.Parse(manager.GetMetric(ComputerMetrics.AverageDiskQueueLength));
            usageData.CpuUsage = Int32.Parse(manager.GetMetric(ComputerMetrics.CpuUsage));
            usageData.RamUsage = Int32.Parse(manager.GetMetric(ComputerMetrics.RamUsage));
            usageData.Time = DateTime.Now;
            computerDetail.UsageDataCollection.Add(usageData);
            context.UsageDatas.Add(usageData);
            context.SaveChanges();





        }

        public ComputerDetail getLastUpdatedComputerDetail()
        {
            return computerDetail;
        }


    }
}
