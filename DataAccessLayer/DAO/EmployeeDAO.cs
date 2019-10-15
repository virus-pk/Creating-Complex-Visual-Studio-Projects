using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfrastructureLayer.VO;
using InfrastructureLayer.Common;
using DataAccessLayer.Models;

namespace DataAccessLayer.DAO
{
    public class EmployeeDAO : ApplicationBase
    {
        public EmployeeDAO() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType) { }

        public EmployeeVO2 CreateEmployee(EmployeeVO2 vo)
        {
            try
            {
                using (var db = new EmployeeTrainingModelContainer())
                {
                    var employee = new Employee
                    {
                        EmployeeNumber = vo.EmployeeNumber,
                        FirstName = vo.FirstName,
                        MiddleName = vo.MiddleName,
                        LastName = vo.LastName,
                        DateOfBirth = vo.DateOfBirth,
                        HireDate = vo.HireDate
                    };
                    db.Employees.Add(employee);
                    db.SaveChanges();

                    var query = from b in db.Employees
                                where b.EmployeeNumber == vo.EmployeeNumber
                                select b;

                    vo.ID = query.First().Id;

                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }

            return vo;
        }

        public void DeleteEmployee(int id)
        {
            try
            {
                using (var db = new EmployeeTrainingModelContainer())
                {
                    Employee employee = (Employee)db.Employees.Where(b => b.Id == id).First();
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }
    }
}
