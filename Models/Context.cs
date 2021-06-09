using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication19.Models
{
    public class Context
    {
        public IEnumerable<Appointment> Appointments { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Clinic> Clinics { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Type> Type { get; set; }
        public IEnumerable<Specialty> Specialties { get; set; }
        public IEnumerable<Comments> Comments { get; set; }
        public IEnumerable<EmployeeOfClinic> EmployeeOfClinics { get; set; }
    }
}