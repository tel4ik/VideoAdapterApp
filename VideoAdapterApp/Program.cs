using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using VideoAdapterApp.Presentor;
using VideoAdapterApp.View;
using VideoAdapterApp.DAL;

namespace VideoAdapterApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IVideoKatalog Katalog;

            IVideoKatalog creater;
            creater = new CreateKatalog();

            IView view = new MainView();
            IPresentor mainPresentor = new MainPresentor(view, creater);
        }
    }
}
