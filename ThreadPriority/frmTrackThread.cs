using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadPriority
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }
        public void MyThreads()
        {
            lbl_Thread.Text = "-Thread Starts-";

            Console.WriteLine("-Thread Starts-");

            MyThreadClass ThreadClass = new MyThreadClass();

            Thread threadA = new Thread(new ThreadStart(ThreadClass.thread1));

            Thread threadB = new Thread(new ThreadStart(ThreadClass.thread2));

            Thread threadC = new Thread(new ThreadStart(ThreadClass.thread1));

            Thread threadD = new Thread(new ThreadStart(ThreadClass.thread2));

            threadA.Priority =System.Threading.ThreadPriority.Highest;
            threadA.Name = "Thread A Process";

            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadB.Name = "Thread B Process";

            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            threadC.Name = "Thread C Process";

            threadD.Priority=System.Threading.ThreadPriority.BelowNormal;
            threadD.Name = "Thread D Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-End of Thread-");
            lbl_Thread.Text = "-End of Thread-";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyThreads();
        }
    }
}
