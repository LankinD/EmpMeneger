using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMenegement.Models
{
    public class Cleaner : Worker
    {

        public int multy { get; }
        public Cleaner(string empname, string empadd, string emppos, string empdob, string empphone, string empgen, int salary) : base(empname, empadd, emppos, empdob, empphone, empgen, salary)
        {
            multy = 2;
        }
        public override int salaryFunc()
        {
            return base.salaryFunc() * multy;
        }
    }
}
