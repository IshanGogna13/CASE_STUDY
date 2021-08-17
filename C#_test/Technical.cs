using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class TechnicalEmployee : Employee
    {
        List<string> skills = new List<string>();
        public List<string> Skills
        {
            get
            {
                return skills;
            }
            set
            {
                skills = value;
            }
        }

        public TechnicalEmployee(int empId, string empName, string address, double basicPay, List<string> sk) : base(empId, empName, address, basicPay)
        {
            skills = sk;
        }

        public override double calculateSalary()
        {
            double hra = 0.12 * BasicPay;
            return BasicPay + hra;
        }
        public override string ToString()
        {
            return $"{empName} has id {empId}";
        }
    }
}
