using PI_I8_AntePrskalo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PI_I8_AntePrskalo.Models
{
    public class TerminalEmployee
    {
        private EmployeeType employeeType;
        private string employeeName;

        public TerminalEmployee(EmployeeType type, String employeeName)
        {
            employeeType = type;
            this.employeeName = employeeName;
        }
        
        public EmployeeType GetEmployeeType()
        {
            return employeeType;
        }

        public override string ToString()
        {
            return employeeName;
        }
    }
}
