using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMenegement.Models
{
    public class Job
    {
      // workerName,description,time,place

        public string WorkerName { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public string Place { get; set; }
        public Job(string workerName="temp", string description="", int time=0, string place = "")
        {
           WorkerName = workerName;
           Description = description;  
           Time = time;
           Place = place;
        }
    }
}
