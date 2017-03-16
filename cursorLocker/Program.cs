using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Timers;

namespace cursorLocker
{
    class TCHandle
    {
          public void tcMethod(Object gg)
        {
            Console.Write("In timer fuckers \n");
            Form1 fi = (Form1)gg;
            fi.setCursorLock();
        }
    }

    static class Program
    {
      
       
        private static Task HandleTimer()
        {
            Console.WriteLine("\nHandler not implemented...");
            //throw new NotImplementedException();
            
            return null;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var autoEvent = new AutoResetEvent(false);
            var tchandle = new TCHandle();
            //     System.Threading.TimerCallback tc = new System.Threading.TimerCallback(new TCHandle.tcMethod);
         
            Form1 fi = new Form1();
            System.Threading.Timer t = new System.Threading.Timer(tchandle.tcMethod, fi, 1000, 250);
            Application.Run(fi);
        }
    }
}
