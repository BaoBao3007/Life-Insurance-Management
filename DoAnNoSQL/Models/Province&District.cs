using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DoAnNoSQL.Models
{
    public class Province_District
    {
        public int error { get; set; }
        public string error_text { get; set; }
        public string data_name { get; set; }
        public List<Location> data { get; set; }
    }

    public class Location
    {
        public string id { get; set; }
        public string name { get; set; }
        public string name_en { get; set; }
        public string full_name { get; set; }
        public string full_name_en { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }

        public override string ToString()
        {
            return full_name;
        }
    }
}
