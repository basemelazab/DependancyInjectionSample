using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionSample
{
    public enum EmployeeType
    {
        Employee1, Employee2
    }
    public interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
    }
    public class Employee1 : IEmployee
    {
        public int ID { get { return 1; }set { value = 1; } }
        public string Name { get { return "Basem"; } set { value = "Basem"; } }
    }
    public class Employee2 : IEmployee
    {
        public int ID { get { return 2; } set { value = 2; } }
        public string Name { get { return "Asmaa"; } set { value = "Asmaa"; } }
    }
    public class EmployeeFactory
    {
        public static IEmployee GetEmployee (EmployeeType empType)
        {
            switch (empType)
            {
                case EmployeeType.Employee1: return new Employee1();
                case EmployeeType.Employee2: return new Employee2();
                default: throw new ArgumentException("Error");
            }
        }
    }
    public class Program
    {
      public  static void Main(string[] args)
        {
            IEmployee employee=EmployeeFactory.GetEmployee (EmployeeType.Employee1);
            Console.WriteLine("ID:{0},Name:{1}",employee.ID,employee.Name);

            employee=EmployeeFactory.GetEmployee (EmployeeType.Employee2);
            Console.WriteLine("ID:{0},Name:{1}", employee.ID, employee.Name);

            Console.ReadLine();
        }
    }
}
