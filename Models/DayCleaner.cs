using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMenegement.Models
{
    public class DayCleaner : Cleaner
    {
        public int dayAddition { get;  }
        public DayCleaner(string empname = "", string empadd = "", string emppos = "", string empdob = "", string empphone = "", string empgen = "", int salary = 0) : base(empname, empadd, emppos, empdob, empphone, empgen, salary)
        {
            dayAddition = 70;
        }
        public override int salaryFunc()
        {
            return base.salaryFunc() + dayAddition;
        }
    }
}
