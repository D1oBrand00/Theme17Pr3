using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr3
{
    /// <summary>
    /// Базовый класс
    /// </summary>
    class Employee
    {
        /// <summary>
        /// Поле имени сотрудника
        /// </summary>
        string name;
        /// <summary>
        /// Поле фамилии сотрудника
        /// </summary>
        string surname;
        /// <summary>
        /// Поле даты рождения сотрудника
        /// </summary>
        DateTime birthDate;
        /// <summary>
        /// Поле минимальной зарплаты сотрудника
        /// </summary>
        int p;
        /// <summary>
        /// Свойства полей
        /// </summary>
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public int P { get => p; set => p = value; }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Employee() { }
        /// <summary>
        /// Конструктор с 4 параметрами
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="dateTime">Дата рождения</param>
        /// <param name="p">Минимальная зарплата</param>
        public Employee(string name, string surname, DateTime birthDate, int p)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
            this.p = p;
        }
        /// <summary>
        /// Метод вычисления дохода
        /// </summary>
        /// <param name="k">повышающий коэффициент</param>
        /// <returns></returns>
        virtual public double Income(double k, double H)
        {
            return p * k;
        }
        /// <summary>
        /// Метод вывода информации о сотруднике
        /// </summary>
        virtual public void Output()
        {
            Console.WriteLine($"Имя - {name}\nФамилия - {surname}\nДата рождения - {birthDate}\nМинимальная зарплата - {p} р.");

        }
    }
}
