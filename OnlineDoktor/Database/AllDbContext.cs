using Common;
using Common.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class AllDbContext : DbContext
    {

        public AllDbContext()
        {
            if(Doctors.Count() < 1)
            {
                Doctors.Add(new Doctor { Name = "Doktor", LastName = "Doktorko", FieldOfWork = Common.Discipline.Surgery, LicenseID = "1" });
                Doctors.Add(new Doctor { Name = "Doktor", LastName = "Doktorko", FieldOfWork = Common.Discipline.Surgery, LicenseID = "2" });
                Doctors.Add(new Doctor { Name = "Doktor", LastName = "Doktorko", FieldOfWork = Common.Discipline.Surgery, LicenseID = "3"});
                Doctors.Add(new Doctor { Name = "Doktor", LastName = "Doktorko", FieldOfWork = Common.Discipline.Surgery, LicenseID = "4" });
                Doctors.Add(new Doctor { Name = "Doktor", LastName = "Doktorko", FieldOfWork = Common.Discipline.Surgery, LicenseID = "5" });
                this.SaveChanges();
            }
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
