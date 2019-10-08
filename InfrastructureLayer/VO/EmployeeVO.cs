using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfrastructureLayer.Common;

namespace InfrastructureLayer.VO
{
    public class EmployeeVO : ApplicationBase
    {
        public EmployeeVO() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            Log.Info("Instance Created");
        }
    }
}
