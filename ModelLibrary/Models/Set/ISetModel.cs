using System.Collections.Generic;
using ModelLibrary.Models.Topic;

namespace ModelLibrary.Models.Set
{
    public interface ISetModel
    {
        int SetID { get; set; }
        string SetName { get; set; }
        List<ITopicModel> SetTopics { get; set; }
    }
}