using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public interface ItemBase
    {
        string Id { get; set; }
        string ParentId { get; set; }
        string TopId { get; set; }
        string CompanyId { get; set; }
        string SiteId { get; set; }
        int Version { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
