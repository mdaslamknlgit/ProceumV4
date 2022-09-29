using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proceum.Models
{
    public class JSONContent
    {
        public int content_id { get; set; }
        public int curriculum_id { get; set; }
        public int is_individual { get; set; }
        public int level_id { get; set; }
        public int level_parent_id { get; set; }
    }
}
