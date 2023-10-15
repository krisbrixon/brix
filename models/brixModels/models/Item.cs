using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class Item : ItemBase
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string TopId { get; set; }
        public string CompanyId { get; set; }
        public string SiteId { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public T ItemType<T>  { get; set; }

    }
}
