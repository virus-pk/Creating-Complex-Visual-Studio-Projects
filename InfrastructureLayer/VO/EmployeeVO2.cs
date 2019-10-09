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
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public EmployeeVO2() : this("John", "Waynne", "Doe")
        {
            StaticLogger.LogInfo(this.GetType(), "Employee Created");
        }

        public EmployeeVO2(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
}
