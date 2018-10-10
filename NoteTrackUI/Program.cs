using NoteTrackUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteTrackUI.Presenters;
using NoteTrackUI.Factory;

namespace NoteTrackUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainViewPresenter mainPresenter = (MainViewPresenter) StaticFactory.CreateMainViewPresenter();
            mainPresenter.ShowMain();

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run();
        }
    }
}
