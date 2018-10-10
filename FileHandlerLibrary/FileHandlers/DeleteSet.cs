using CommonComponents;
using ModelLibrary.Models.Set;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlerLibrary.FileHandlers
{
    public static class DeleteSet
    {
        public static void Delete(string selectedSetName)
        {
            DataAccessStatus dataAccessStatus = new DataAccessStatus();
            try
            {
                var path = Path.Combine(Base._setsFolder, selectedSetName);
                Directory.Delete(path, true);
            }
            catch (DirectoryNotFoundException e)
            {
                dataAccessStatus.setValues(status: "Error", operationSucceeded: false, exceptionMessage: e.Message, customMessage: $"Directory {SetModel.SelectedSet} wasn't found", stackTrace: e.StackTrace);
                throw new DataAccessException(dataAccessStatus);
            }
        }
    }
}
