using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDT.Db.Models
{
    public class DevTest
    {
        public int Id { get; set; }
        public String CampaingnName { get; set; }
        public DateTime? Date { get; set; }
        public int? Clicks { get; set; }
        public int? Conversions { get; set; }
        public int? Impressions { get; set; }
        public String AffiliateName { get; set; }
    }
}