using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models.Topic
{
    public class TopicModel : ITopicModel
    {
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Set name must be between 2 and 20 characters long")]
        public string TopicName { get; set; }
        public byte[] TopicFile { get; set; }
        public List<string> TopicVideos { get; set; }= new List<string>();
    }
}
