using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SetLibrary
{
    public class Set : SetList
    {
        //private string _Title { get; set; }
        public string Title { get; set; }
        public static string SelectedTopic;
        public List<string> Topics = new List<string>();

        public Set()
        {

        }

        public Set(string title)
        {
            Title = GetSafeFilename(title);
            List<string> Topics = new List<string>();
        }

        public string GetSafeFilename(string filename)
        {

            return string.Join("", filename.Split(Path.GetInvalidFileNameChars()));

        }
        
        public void ClearTopics()
        {
            Topics.Clear();
        }

        public void AddTopic(string topic)
        {
            Topics.Append(topic);
        }

        public void PopulateTopics(string exefolder)
        {
            string topicfolder = Path.Combine(exefolder, "Sets");
            topicfolder = Path.Combine(topicfolder, Title);
            foreach (var topic in Directory.GetDirectories(topicfolder))
            {
                Topics.Add(topic.Remove(0, topic.LastIndexOf("\\") + 1));
            }
        }
        
    }
}
