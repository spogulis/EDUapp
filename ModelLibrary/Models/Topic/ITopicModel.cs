using System.Collections.Generic;
using System.IO;

namespace ModelLibrary.Models.Topic
{
    public interface ITopicModel
    {
        string TopicName { get; set; }
        byte[] TopicFile {get; set; }
        List<string> TopicVideos { get; set; }
    }
}