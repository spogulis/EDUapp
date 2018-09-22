using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SetLibrary
{
    public class Topic : Set
    {
        private static List<string> _videoList = new List<string>();
        public static ReadOnlyCollection<string> VideoList
        {
            get { return _videoList.AsReadOnly(); }
        }

        public Topic(string topicname)
        {
            List<string> VideoList = new List<string>();
            SelectedTopic = topicname;
        }

        public void PopulateVideoList(string file)
        {
            _videoList.Add(file);
        }

        public static void ClearVideoList()
        {
            _videoList.Clear();
        }
    }
}
