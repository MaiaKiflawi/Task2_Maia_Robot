﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        private double monthlyPay;
        private int workMonths;
        private int activeRobots;

        public GeneralManager(double monthlyPay, int workMonths, int activeRobots,string name, string id, DateTime bDate, string pass, double monthlySalary)
            :base (name,id,bDate,pass)
        {
            this.monthlyPay = monthlyPay;
            this.workMonths = workMonths;
            this.activeRobots = activeRobots;
        }

        public override double WorkerSalary()
        {
            double sal = monthlyPay * workMonths;
            double bonus = 0;
            if (activeRobots > 15)
            {
                bonus = sal * 0.15;
            }
            return sal + bonus;
        }

        

    }
}
