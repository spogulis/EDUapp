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
    public static class GetBySetName
    {
        private static SetModel _setModel;

        public static SetModel GetByName(string selectedSet)
        {
            DataAccessStatus dataAccessStatus = new DataAccessStatus();
            

            try
            {
                int index = 0;
                //Get all sets
                foreach(string setFolder in Directory.GetDirectories(Base._setsFolder))
                {
                    _setModel = new SetModel();
                    _setModel.SetName = setFolder.Remove(0, setFolder.LastIndexOf('\\') + 1);
                    _setModel.SetID = index;

                    //If set folder matches passed in set name
                    if (setFolder.Remove(0, setFolder.LastIndexOf('\\') + 1) == selectedSet)
                    {
                        //Get set's topics from folder names
                        foreach(string topicFolder in Directory.GetDirectories(setFolder))
                        {
                            TopicModel topicModel = new TopicModel();

                            topicModel.TopicName = topicFolder.Remove(0, topicFolder.LastIndexOf('\\') + 1);

                            string tfile = topicFolder + @"\" + topicModel.TopicName + ".rtf";
                            byte[] topicFileInBytes = Encoding.ASCII.GetBytes(tfile); 
                            topicModel.TopicFile = topicFileInBytes; //Set topicModel.TopicFile
                            //Get list of videos
                            string videoFolder = Path.Combine(topicFolder, "Videos");
                            foreach(string topicVideo in Directory.GetFiles(videoFolder, ("*.mp4, *.avi"))) { 
                                //TODO: Sort results?
                                topicModel.TopicVideos.Add(topicVideo);
                            }
                        _setModel.SetTopics.Add(topicModel); //Add topicModel to set 
                        }
                    return _setModel;
                    }
                index++;
                }
            }
            catch (DirectoryNotFoundException e)
            {
                dataAccessStatus.setValues(status: "Error", operationSucceeded: false, exceptionMessage: e.Message, customMessage: $"Directory {_setModel.SetName} wasn't found", stackTrace: e.StackTrace);
                return null;
                //throw new DataAccessException(dataAccessStatus);
            }
            return null;
        }
    }
}
