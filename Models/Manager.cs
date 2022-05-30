using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMenegement.Models
{
    public class Manager : Worker
    {
        public int Addition { get; }
        public Manager(string emppos="Manager", string empname = "", string empadd = "", string empdob = "", string empphone = "", string empgen = "", int salary = 0) : base(empname, empadd, emppos, empdob, empphone, empgen, salary)
        {
            Addition = 250;
        }
        public override int salaryFunc()
        {
            return base.salaryFunc() + Addition;
        }
    }
}
