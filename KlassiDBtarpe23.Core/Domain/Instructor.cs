using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiDBtarpe23.Core.Domain
{
    public class Instructor
    {
        [Key]
        public Guid InstructorID { get; set; }

        public string ClassName { get; set; }
        public string InstructorName { get; set; }
        
        public int ClassAssignments { get; set; }     
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,Female
    }
}
