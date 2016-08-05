using WinFormsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataWriter;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Form1 form = new Form1();
            //form.Show();
            //form.BeginInvoke(AsyncCallback, state);


            Clock clock = new Clock();
            clock.UpdateFinished+= form.UpdateInformation;
            DataUpdater updater = new DataUpdater();
            clock.SetDataUpdater(updater);
            updater.UpadatStaticeComputerData();
            Console.WriteLine("haha");
            Thread d = new Thread();

            d.Start

            


            clock.Start();


        }

        

  

    


    }
        
}
