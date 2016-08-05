using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    class Clock
    {


        private Thread _thread;
        private SynchronizationContext _syncContext;

        public event EventHandler UpdateFinished;

        public Clock()
        {
            _syncContext = WindowsFormsSynchronizationContext.Current;

            ThreadStart threadStart = new ThreadStart(ThreadStartMethod);
            _thread = new Thread(threadStart);
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
                   

                    OnUpdateFinished(); // Notify all subscribers (on their own threads)  
                    Thread.Sleep(3000); // 1 sec wait before the next update  
                }
            }
            catch (ThreadAbortException)
            {
                // The thread was aborted... ignore this exception if it's safe to do so  
            }
        }

        protected virtual void OnUpdateFinished()
        {
            if (UpdateFinished != null)
            {
                SendOrPostCallback method = new SendOrPostCallback(
                delegate (object state)
                {
                    UpdateFinished(this, EventArgs.Empty);
                });
                _syncContext.Send(method, null);
            }
        }
    }
}
