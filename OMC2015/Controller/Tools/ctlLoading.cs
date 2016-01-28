using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OMC2015.Controller.Tools
{
    public class Loading
    {
        public Thread ProgressThread = new Thread(delegate()
        {
            View.Tools.frmLoading _Loading = new View.Tools.frmLoading();
            _Loading.ShowDialog();
        });

        public void Start()
        {
            try
            {
                if (ProgressThread.ThreadState == ThreadState.Unstarted)
                {
                    ProgressThread.Start();
                }
                else if (ProgressThread.ThreadState == ThreadState.Aborted)
                {
                    ProgressThread.Join();
                }
            }
            catch (Exception Ex)
            {
                using (View.Tools.frmErrorMessage Message = new View.Tools.frmErrorMessage())
                {
                    Message.Text = "Loading Error...";
                    Message.TextError = Ex.ToString();
                    Message.ShowDialog();      
                    //Test Pull              
                }
            }
        }

        public void Abort()
        {
            ProgressThread.Abort();
        }
    }
}
