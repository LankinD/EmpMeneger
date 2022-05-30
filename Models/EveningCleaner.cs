using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMenegement.Models
{
    public class EveningCleaner : Cleaner
    {
        public int Addition { get; }
        public EveningCleaner(string empname = "", string empadd = "", string emppos = "", string empdob = "", string empphone = "", string empgen = "", int salary=0) : base(empname, empadd, emppos, empdob, empphone, empgen, salary)
        {
            Addition = 50;
        }
        public override int salaryFunc()
        {
            return base.salaryFunc() + Addition;
        }
    }
}
