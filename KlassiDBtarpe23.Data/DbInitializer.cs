using KlassiDBtarpe23.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassiDBtarpe23.Data
{
    public class DbInitializer
    {
        public static void Initialize(KlassiDBtarpe23DbContext context)
        {
            //Teeb, kindlaks, et andmebaas thakse, või oleks olemas
            context.Database.EnsureCreated();

            //Kui õpliaste tabelis juba on õpilasi, siis väljub funktsioon
            if (context.Student.Any())
            {
                return;
            }

            //objekti õpilastega, mis lisatakse siis, kui õpilasi sisestatud ei ole
            var students = new Student[]
            {
                new Student { ClassName="1a", StudentName="Pablo", Age=7},
                new Student { ClassName="1b", StudentName="Pablo-Juunior", Age=7},
                new Student { ClassName="1c", StudentName="James", Age=7},
                new Student { ClassName="2a", StudentName="Joosep", Age=8},
                new Student { ClassName="2b", StudentName="Mardo", Age=8},
                new Student { ClassName="2ac", StudentName="Mario", Age=8},
                new Student { ClassName="3a", StudentName="Juss", Age=9},
                new Student { ClassName="3b", StudentName="Peeter-paan", Age=9},
                new Student { ClassName="3c", StudentName="Jaanus", Age=9},
                new Student { ClassName="4a", StudentName="Billy", Age=10},

            };

            // Iga õpilane lisatakse ükssaaval läbi forreach tsükli
            foreach (Student student in students)
            {
                context.Student.Add(student);
            }
            //andmebaasi muudatused salvestatakse
            context.SaveChanges();

            if (context.Class.Any())
            {
                return;
            }

            //objekti õpilastega, mis lisatakse siis, kui õpilasi sisestatud ei ole
            var classes = new Class[]
            {
                new Class { ClassName="1a" },
                new Class { ClassName="1b" },
                new Class { ClassName="1c" },
                new Class { ClassName="2a" },
                new Class { ClassName="2b" },
                new Class { ClassName="2c" },
                new Class { ClassName="3a" },
                new Class { ClassName="3b" },
                new Class { ClassName="3c" },
                new Class { ClassName="4a" }

            };

            // Iga õpilane lisatakse ükssaaval läbi forreach tsükli
            foreach (Class Class in classes)
            {
                context.Class.Add(Class);
            }
            //andmebaasi muudatused salvestatakse
            context.SaveChanges();


            if (context.Instructor.Any())
            {
                return;
            }

            //objekti õpilastega, mis lisatakse siis, kui õpilasi sisestatud ei ole
            var insructors = new Instructor[]
            {
                new Instructor { ClassName="1a", InstructorName="Mari", ClassAssignments=3, Gender=Gender.Female},
                new Instructor { ClassName="3a", InstructorName="Mari", ClassAssignments=3, Gender=Gender.Female},
                new Instructor { ClassName="4a", InstructorName="Mari", ClassAssignments=3, Gender=Gender.Female},
                new Instructor { ClassName="1b", InstructorName="Toomas", ClassAssignments=2, Gender=Gender.Male},
                new Instructor { ClassName="2a", InstructorName="Toomas", ClassAssignments=2, Gender=Gender.Male},
                new Instructor { ClassName="2b", InstructorName="Eve", ClassAssignments=1, Gender=Gender.Female},
                new Instructor { ClassName="1c", InstructorName="Markus", ClassAssignments=2,  Gender=Gender.Male},
                new Instructor { ClassName="2c", InstructorName="Markus", ClassAssignments=2,  Gender=Gender.Male},
                new Instructor { ClassName="3b", InstructorName="Maret", ClassAssignments=2,Gender=Gender.Female},
                new Instructor { ClassName="3c", InstructorName="Maret", ClassAssignments=2,Gender=Gender.Female},




            };

            // Iga õpilane lisatakse ükssaaval läbi forreach tsükli
            foreach (Instructor instructor in insructors)
            {
                context.Instructor.Add(instructor);
            }
            //andmebaasi muudatused salvestatakse
            context.SaveChanges();

            if (context.Coupon.Any())
            {
                return;
            }

            //objekti õpilastega, mis lisatakse siis, kui õpilasi sisestatud ei ole
            var coupons = new Coupon[]
            {
                new Coupon { StudentName="Pablo" },
                new Coupon { StudentName="Pablo-Juunior" },
                new Coupon { StudentName="James" },
                new Coupon { StudentName="Joosep" },
                new Coupon { StudentName="Mardo" },
                new Coupon { StudentName="Mario" },
                new Coupon { StudentName="Juss" },
                new Coupon { StudentName="Peeter-paan" },
                new Coupon { StudentName="Jaanus" },
                new Coupon { StudentName="Billy" }


            };

            // Iga õpilane lisatakse ükssaaval läbi forreach tsükli
            foreach (Coupon coupon in coupons)
            {
                context.Coupon.Add(coupon);
            }
            //andmebaasi muudatused salvestatakse
            context.SaveChanges();



        }     
    }
}
