using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZDCore;

namespace ZDWindowsFormsTest
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
           
            ZDNetworkSerializable.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
        }
    }
}
