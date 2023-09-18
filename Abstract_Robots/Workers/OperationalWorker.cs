using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker :Worker 
    {
        protected double hourlyPay;
        protected int workHours;

        public OperationalWorker(string name, string id, DateTime bDate, string pass, double hourlyPay, int workHours)
            : base(name, id, bDate, pass)
        {
           this.hourlyPay = hourlyPay;
            this.workHours = workHours;
        }

        public override double WorkerSalary()
        {
            return hourlyPay * workHours;
        }
    }
}
