using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Staff : Employee                                               //class staff inheriting employee
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
        public Staff(int empId, string empName, string address, double basicPay, string tit) : base(empId, empName, address, basicPay)  //constructor
        {
            title = tit;
        }

        public override double calculateSalary()                                    //to calc salary
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
