using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiDBtarpe23.Core.Domain
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }  // Auto-incremented ID for database use
        public string ClassName { get; set; }  // e.g., "1a", "1b", "2a"
        
        

    }
}
