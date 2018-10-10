using CommonComponents;
using ModelLibrary.Models.Set;
using ModelLibrary.Models.Topic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlerLibrary.FileHandlers
{
    public class AddSet
    {
        public AddSet()
        {

        }
        public bool Add(ISetModel setModel, ITopicModel topicModel, byte[] file)
        {
            DataAccessStatus dataAccessStatus = new DataAccessStatus();
            try
            {
                string path = Path.Combine(Base._setsFolder, setModel.SetName);
                if (Directory.Exists(path))
                {
                    return false;
                }
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path); //Create set folder
                }
                path = Path.Combine(path, topicModel.TopicName); //Change path to /SetName/TopicName
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path); //Create topic folder
                }
                string filename = Path.Combine(path, topicModel.TopicName);
                filename += ".rtf";
                if (!File.Exists(filename))
                {
                    //using(File.Create(filename));
                    using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
                    {
                        MemoryStream ms = new MemoryStream(file);
                        ms.WriteTo(fs);
                        fs.Close();
                        ms.Close();
                    }
                }

                path = Path.Combine(path, "Videos");
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path); //Create Videos folder
                }
                path = Path.Combine(path, "Thumbnails");
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path); //Create Thumbnail folder
                }
                return true;
            }
            catch (IOException e)
            {
                dataAccessStatus.setValues(status: "Error", operationSucceeded: false, exceptionMessage: e.Message, customMessage: "Set already exists", stackTrace: e.StackTrace);
                throw new DataAccessException(e.Message, e.InnerException, dataAccessStatus);
            }
        }
    }
}
