using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfrastructureLayer.Common;

namespace InfrastructureLayer.VO
{
    public class EmployeeVO2
    {
        public int ID { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }

        public EmployeeVO2() : this(0, "999999999", "John", "Waynne", "Doe", DateTime.Now, DateTime.Now)
        {
            StaticLogger.LogInfo(this.GetType(), "Employee Created");
        }

        public EmployeeVO2(int iD, string employeeNumber, string firstName, string middleName, string lastName, DateTime dateOfBirth, DateTime hireDate)
        {
            ID = iD;
            EmployeeNumber = employeeNumber;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            HireDate = hireDate;
            StaticLogger.LogInfo(this.GetType(), "Employee Created");
        }



        //public EmployeeVO2(string firstName, string middleName, string lastName)
        //{
        //    FirstName = firstName;
        //    MiddleName = middleName;
        //    LastName = lastName;
        //}
    }
}
