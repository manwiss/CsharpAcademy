using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Entity;

namespace DataWriter
{
    class Clock
    {


        private Thread _thread;
        private SynchronizationContext _syncContext;
        private DataUpdater dataUpdater;

        public event EventHandler<ComputerDetailsEventArgs> UpdateFinished;

        public Clock()
        {

            _syncContext = SynchronizationContext.Current;
            ThreadStart threadStart = new ThreadStart(ThreadStartMethod);
            _thread = new Thread(threadStart);
            //_thread.SetApartmentState(System.Threading.ApartmentState.STA);
            _thread.Name = "UpdateThread";
            _thread.IsBackground = true;
            _thread.Priority = System.Threading.ThreadPriority.Normal;
        }

        public void Start()
        {
            if ((_thread.ThreadState & ThreadState.Unstarted) == ThreadState.Unstarted)
                _thread.Start();
            else
                throw new Exception("Thread has already been started and may have completed already.");
        }

        public void ThreadStartMethod()
        {
            try
            {
                while (true)
                {
                    

                    OnUpdateFinished(dataUpdater.getLastUpdatedComputerDetail()); // Notify all subscribers (on their own threads)
                    Thread.Sleep(3000); // 1 sec wait before the next update  
                }
            }
            catch (ThreadAbortException)
            {
                // The thread was aborted... ignore this exception if it's safe to do so  
            }
        }

        protected virtual void OnUpdateFinished(ComputerDetail computerDetail)
        {
            if (UpdateFinished != null)
            {
                SendOrPostCallback method = new SendOrPostCallback(
                delegate (object state)
                {
                    UpdateFinished(this, new ComputerDetailsEventArgs(){ComputerDetails=computerDetail});
                });
            }
        }

        public void SetDataUpdater(DataUpdater updater)
        {
            dataUpdater = updater;
        }
    }
}
