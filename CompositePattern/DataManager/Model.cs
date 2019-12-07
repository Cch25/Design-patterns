using System.Collections.Generic;

namespace CompositePattern.DataManager
{
    public class Folder
    {
        public string fileName { get; set; }
        public int value { get; set; }
        public List<Folder> folders { get; set; }
    }

    public class RootObject
    {
        public string fileName { get; set; }
        public List<Folder> folders { get; set; }
    }
}
