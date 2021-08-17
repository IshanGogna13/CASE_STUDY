using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
        
    
       
        class UsingPeople
        {
        public static void Main()
        { 
            List<string> ski = new List<string> ( );
            ski.Add("C++");
            ski.Add("Java");
            Employee emp;
            emp = new TechnicalEmployee(123, "avi", "balrampur", 13345,ski );
           
            Console.WriteLine($"Employee Id is :{emp.EmpId}");
            Console.WriteLine($"Employee Name is :{emp.EmpName}");
            Console.WriteLine($"Employee Salary is :{emp.calculateSalary()}");
            Employee empp;
            
            empp = new Staff(4566, "Ishan", "Gurgaon", 50000, "hii");
          
            Console.WriteLine($"Employee : {empp.ToString()}");
            Console.WriteLine($"Employee salary is: {empp.calculateSalary()}");



        }

        }
}
