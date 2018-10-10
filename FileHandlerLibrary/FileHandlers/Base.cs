using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlerLibrary.FileHandlers
{
    public static class Base
    {
        public static string _exeFolder = AppDomain.CurrentDomain.BaseDirectory;
        public static string _setsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sets");
    }
}
