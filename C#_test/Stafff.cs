using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Staff : Employee
    {
        string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                Title = title;
            }
        }
        public Staff(int empId, string empName, string address, double basicPay, string tit) : base(empId, empName, address, basicPay)
        {
            title = tit;
        }

        public override double calculateSalary()
        {
            double hra = 0.18 * BasicPay;
            return BasicPay + hra;
        }
        public override string ToString()
        {
            return $"{empName} has id {empId}";
        }

    }
}
