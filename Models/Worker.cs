using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMenegement.Models
{
    public class Worker
    {
        public string EmpName { get; set; }
        public string EmpAddres { get; set; }
        public string EmpPos { get; set; }
        public string EmpDOB { get; set; }
        public string EmpPhone { get; set; }
        public string EmpGen { get; set; }
        public int EmpSalary { get; set; }
        public int hours { get; set; }
        public Worker(string empname, string empadd, string emppos, string empdob, string empphone, string empgen, int empsalary)
        {
            EmpName = empname;
            EmpAddres = empadd;
            EmpPos = emppos;
            EmpDOB = empdob;
            EmpPhone = empphone;
            EmpGen = empgen;
            EmpSalary = empsalary;
            hours = 0;
        }
        public virtual int salaryFunc()
        {
            return EmpSalary * hours;
        }
        public void AddToHours(int num)
        {
            hours += num;
        }
    }
}
