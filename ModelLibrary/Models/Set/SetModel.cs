using ModelLibrary.Models.Topic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelLibrary.Models.Set
{
    public class SetModel : ISetModel
    {
        public int SetID {get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Set name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Set name must be between 2 and 20 characters long")]
        public string SetName { get; set; }
        public List<ITopicModel> SetTopics { get; set; } = new List<ITopicModel>();
        public static string SelectedSet { get; set; }
        public static string SelectedTopic { get; set; }

        public SetModel()
        {
            
        }
    }
}
