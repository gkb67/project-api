using System;
using System.Collections.Generic;

namespace Crud
{
    public class SingleUser
    {
        public DataSingleUser data { get; set; }
        public SupportSingleUser support { get; set; }
    }

    public class DataSingleUser
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }

    public class SupportSingleUser
    {
        public string url { get; set; }
        public string text { get; set; }
    }
}
