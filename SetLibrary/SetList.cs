using System;
using System.Collections.Generic;
using System.Text;

namespace SetLibrary
{
    public abstract class SetList
    {
        public static List<string> SetNames = new List<string>();
        
        //Constructor
        public SetList()
        {
        List<string> SetNames = new List<string>();
        }

        public static void AddSetNames(string value)
        {
            if (!SetNames.Contains(value))
            {
                SetNames.Add(value);
            }
        }
    }
}
