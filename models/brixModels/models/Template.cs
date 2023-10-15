using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class Template
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string TopId { get; set; }
        public string CompanyId { get; set; }
        public string SiteId { get; set; }
        public string ApplicationId { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDateTime { get; set; }
        public string ModifedBy { get; set; }
        public string ModifiedDateTime { get; set; }
    }
}
