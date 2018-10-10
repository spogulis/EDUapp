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
    public static class GetAllSets
    {
        public static IEnumerable<ISetModel> GetAll()
        {
            List<SetModel> setModelList = new List<SetModel>();
            DataAccessStatus dataAccessStatus = new DataAccessStatus();
            try
            {
                int index = 0;
                //Get list of sets
                foreach(string setFolder in Directory.GetDirectories(Base._setsFolder))
                {
                    SetModel _setModel = new SetModel();
                    _setModel.SetName = setFolder.Remove(0, setFolder.LastIndexOf('\\') + 1);
                    _setModel.SetID = index;

                    //Get list of topics
                    foreach(string topicFolder in Directory.GetDirectories(setFolder))
                    {
                        TopicModel topicModel = new TopicModel();
                        if (topicFolder != setFolder + @"\Videos")
                        {
                            topicModel.TopicName = topicFolder.Remove(0, topicFolder.LastIndexOf('\\') + 1);

                            string tfile = topicFolder + @"\" + topicModel.TopicName + ".rtf";
                            byte[] topicFileInBytes = Encoding.ASCII.GetBytes(tfile); 
                            topicModel.TopicFile = topicFileInBytes;
                            //Get list of videos
                            string videoFolder = Path.Combine(topicFolder, "Videos");
                            foreach (string topicVideo in Directory.GetFiles(videoFolder, ("*.mp4")))  { 
                                //TODO: Sort results?
                                topicModel.TopicVideos.Add(topicVideo);
                            }
                            _setModel.SetTopics.Add(topicModel); //Add topicModel to setModel
                        }
                    }
                setModelList.Add(_setModel); //Add setModel to setModelList
                index++;
                }
            }
            catch (DirectoryNotFoundException e)
            {
                dataAccessStatus.setValues(status: "Error", operationSucceeded: false, exceptionMessage: e.Message, customMessage: "Directory doesn't exist", stackTrace: e.StackTrace);
                throw new DataAccessException(e.Message, e.InnerException, dataAccessStatus);
            }
            return setModelList;
        }
    }
}
