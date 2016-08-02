using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using DataLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// console output doesnt matter, DATAMANAGER could return the summary, could return the hardware and application list, if i can get those - so good!
            var dataManager = new FullDataManager();

            var computername = dataManager.GetMetric(ComputerMetrics.ComputerName);
            Console.WriteLine($"Computer Name: {computername}");

            var userName = dataManager.GetMetric(ComputerMetrics.User);
            Console.WriteLine($"Current user name: {userName}");

            var cpuUsage = dataManager.GetMetric(ComputerMetrics.CpuUsage);
            Console.WriteLine($"Current CPU usage: {cpuUsage}%");

            var AmountOfRam = dataManager.GetMetric(ComputerMetrics.Ram);
            Console.WriteLine($"Total amount of ram: {AmountOfRam}kb");

            var NameOfVideoCard = dataManager.GetMetric(ComputerMetrics.VideoCard);
            Console.WriteLine($"Name of video card: {NameOfVideoCard}");

            var IP = dataManager.GetMetric(ComputerMetrics.Ip);
            Console.WriteLine($"Curent IP adress: {IP}");

            var RamPercentage = dataManager.GetMetric(ComputerMetrics.RamUsage);
            Console.WriteLine($"Total amount of ram used: {RamPercentage}%");

            var NameOfCpu = dataManager.GetMetric(ComputerMetrics.CpuName);
            Console.WriteLine($"Name of CPU: {NameOfCpu}");

            var availableDiskSpace = dataManager.GetMetric(ComputerMetrics.AvailableDiskSpace);
            Console.WriteLine($"Available disk disk space: {availableDiskSpace}MB");


            var DiskQueueLenght = dataManager.GetMetric(ComputerMetrics.AverageDiskQueueLength);
            Console.WriteLine($"Average disk queue lenght: {DiskQueueLenght}");

            List<string> applicationList = dataManager.GetApplicationList();

            Console.WriteLine();
            Console.WriteLine("List of applications installed");
            foreach (string item in applicationList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("List of hardware");
            
            List<string> HardwareList = dataManager.GetHardwareList();
            foreach (var Hardware in HardwareList)
            {
                Console.WriteLine(Hardware);
            }








        }
    }
}
