using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme17Pr3
{
    /// <summary>
    /// Производный класс от Employee
    /// </summary>
    class Manager : Employee
    {
        /// <summary>
        /// Поле объёма продаж(в тоннах)
        /// </summary>
        int volumeofSales;

        /// <summary>
        /// Свойство поля 
        /// </summary>
        public int VolumeofSales { get => volumeofSales; set => volumeofSales = value; }
        /// <summary>
        /// Конструктор производного класса с 5 параметрами
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="p">Минимальная зарплата</param>
        /// <param name="volumeofSales">Объём продаж(в тоннах)</param>
        public Manager(string name, string surname, DateTime birthDate, int p, int volumeofSales) : base(name, surname, birthDate, p)
        {
            this.volumeofSales = volumeofSales;
        }
        /// <summary>
        /// Метод изменения дохода в зависимости от объёма продаж
        /// </summary>
        /// <returns></returns>
        public override double Income(double k, double H)
        {
            if (volumeofSales > H)
            { return base.Income(k,H) + (H * 0.01); }
            else { return base.Income(k,H); }
        }
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Объём продаж - {volumeofSales}\nДоход менеджера в зависимости от обьъёма продаж - {Income()}");
        }
    }
}
