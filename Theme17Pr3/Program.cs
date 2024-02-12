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
            DateTime dt = new DateTime(2006,03,20);
            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee("Даниил", "Полозюк",dt, 16946 ));
            empl.Add(new Employee("", "", dt, 13564));
            empl.Add(new Employee("", "", dt, 12766));
            empl.Add(new Employee("", "", dt, 8563));
            empl.Add(new Employee("", "", dt, 1756));

            foreach (var elem in empl)
            {
                double k = 2;
                double H = 15; //15 тонн объём продаж
                elem.Income(k,H);
                elem.Output();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
