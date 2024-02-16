using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr3
{
    class Engineer : Employee
    {
        /// <summary>
        /// Поле кол-ва разработанных проектов
        /// </summary>
        int n;
        /// <summary>
        /// Свойства поля
        /// </summary>
        public int N { get => n; set => n = value; }
        /// <summary>
        /// Конструктор производного класса с 5 параметрами
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="p">Минимальная зарплата</param>
        /// <param name="n">Кол-во разработанных проектов</param>
        public Engineer (string name, string surname, DateTime birthDate, int p, int n) : base(name, surname, birthDate, p)
        {
            this.n = n;
        }
        /// <summary>
        /// Метод изменения дохода на 4.8*n
        /// </summary>
        /// <param name="k"></param>
        /// <param name="H"></param>
        /// <returns></returns>
        public override double Income(double k, double H)
        {
            return base.Income(k, H) + 4.8 * n;
        }
        /// <summary>
        /// Метод вывода ифнормации
        /// </summary>
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Кол-во разработанных проектов - {n}\nДоход менеджера увеличить на 4.8*n - {Income}");
        }






    }

        
    
}
