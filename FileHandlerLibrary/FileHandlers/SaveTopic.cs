using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlerLibrary.FileHandlers
{
    public static class SaveTopic 
    {
        public static string Save(string setname, string topicname)
        {
            //File path
            string path = Path.Combine(Base._setsFolder, setname);
            path = Path.Combine(path, topicname);
            path = Path.Combine(path, topicname);
            path += ".rtf";


            //Create and write to file
            if (System.IO.File.Exists(path))
            {
                //do nothing
            }
            else
            {
#pragma warning disable CS0642 // Possible mistaken empty statement
                using (System.IO.File.Create(path));
                //Return path to caller
                return path;
            }
            return path;
        }
    }
}
