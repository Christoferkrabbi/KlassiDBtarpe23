using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiDBtarpe23.Core.Domain
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        
        public string ClassName { get; set; }  // e.g., "1a", "1b", "2a"
        public string StudentName { get; set; }
        public int Age { get; set; }
       
    }


}
