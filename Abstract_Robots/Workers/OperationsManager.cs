using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        protected double hourlyPay;
        protected int workHours;
        protected int tasksDone;

        public OperationManager(double hourlyPay, int workHours, int tasksDone, string name, string id, DateTime bDate, string pass)
            : base(name, id, bDate, pass)
        {
            this.hourlyPay = hourlyPay;
            this.workHours = workHours;
            this.tasksDone = tasksDone;
        }

        public override double WorkerSalary()
        {
            double sal = hourlyPay * workHours;
            double bonus = sal * 0.03;
            return bonus * tasksDone + sal;
        }

        

    }
}
