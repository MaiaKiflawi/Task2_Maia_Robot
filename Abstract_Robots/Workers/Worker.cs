using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        protected string fullName;
        protected string idNumber;
        protected DateTime birthDate;
        protected string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            this.fullName = name;
            this.idNumber = id;
            this.birthDate = bDate;
            this.password = pass;
        }

        public string GetFullName() {  return fullName; }
        public string GetIdNumber() { return idNumber; }
        public DateTime GetBirthDate() { return birthDate; }
        public string GetPassword() { return password; }

        public void SetFullName(string name) {  this.fullName = name; }
        public void SetPassword(string pass) { this.password = pass; }
        
        public abstract double WorkerSalary();

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
