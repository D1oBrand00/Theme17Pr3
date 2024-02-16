using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee("Даниил", "Полозюк", new DateTime(2006,03,20), 10000));
            empl.Add(new Employee("", "", new DateTime(2006, 03, 20), 13564));
            empl.Add(new Employee("", "", new DateTime(2006, 03, 20), 12766));
            empl.Add(new Employee("", "", new DateTime(2006, 03, 20), 8563));
            empl.Add(new Employee("", "", new DateTime(2006, 03, 20), 1756));
            empl.Add(new Manager("", "", new DateTime(2006, 03, 20), 1756,2000));

            foreach (var elem in empl)
            {
                double k = 2;
                double H = 1500; 
                elem.Income(k, H);
                elem.Output();
                
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
