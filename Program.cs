using System;
using System.Windows.Forms;

namespace CopyDirectory
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CopyDirectory_DCSL());
        }
    }
}
