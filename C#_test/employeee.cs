using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Employee
    {
        public int empId;
        public string empName;
        public string address;
        public double basicPay;

        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
        }
        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public double BasicPay
        {
            get
            {
                return basicPay;
            }
            set
            {
                basicPay = value;
            }
        }
        public Employee(int empId, string empName, string address, double basicPay)
        {
            EmpId = empId;
            EmpName = empName;
            Address = address;
            BasicPay = basicPay;
        }
        public override string ToString()
        {
            return $"{empName} has id {empId}";
        }

        public abstract double calculateSalary();
    }
}
