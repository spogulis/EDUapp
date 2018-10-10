using ModelLibrary.Models.Set;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlerLibrary.FileHandlers
{
    public static class UpdateSet
    {
        public static void Update(string oldSetName, string newSetName)
        {
            try
            {
                int index = 0;
                //Get all sets
                foreach(string setFolder in Directory.GetDirectories(Base._setsFolder))
                {
                    //string oldname = setFolder.Remove(0, setFolder.LastIndexOf('\\') + 1);
                    string newName = setFolder.Remove(setFolder.LastIndexOf('\\'), setFolder.Length - setFolder.LastIndexOf('\\')) + @"\" + newSetName;

                    //If set folder matches passed in set name
                    if (setFolder.Remove(0, setFolder.LastIndexOf('\\') + 1) == oldSetName)
                    {
                        //string newName = setFolder.Remove((setFolder.LastIndexOf('\\') + 1)), setFolder.Length - (setFolder.Remove(0, setFolder.LastIndexOf('\\')) + newSetName;
                        if (setFolder.ToLower() != newName.ToLower()) 
                        {
                            Directory.Move(setFolder, newName);
                        }
                    }
                    index++;
                }
            }
            catch (DirectoryNotFoundException e)
            {
                //dataAccessStatus.setValues(status: "Error", operationSucceeded: false, exceptionMessage: e.Message, customMessage: $"Directory {setModel.SetName} wasn't found", stackTrace: e.StackTrace);
                //return null;
                //throw new DataAccessException(dataAccessStatus);
            }
        }
    }
}
