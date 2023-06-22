using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingManagementApplication
{
    internal class Program
    {
        internal static FormHome mainform;
        [STAThread]
        static void Main()
        {
           // MessageBoxManager.OK = "Alright";
            MessageBoxManager.Yes = "Check bill";
            MessageBoxManager.No = "Wedding Info";
            MessageBoxManager.Cancel = "Cancel";
            MessageBoxManager.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
