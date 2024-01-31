using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class DateClass
    {
        private DateTime data;

        // конструктор без параметров
        public DateClass()
        {
            data = DateTime.Now;
        }

        // конструктор с  параметрами 
        public DateClass(int year, int month, int day)
        {
            SetDate(year, month, day);
        }

        // свойство для доступа к полю класса
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        // метод для установки  даты
        public void SetDate(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }

        // метод для вычисления даты пред. дня
        public DateTime PreviousDay()
        {
            return data.AddDays(-1);
        }

        // метод для вычисления даты след. дня
        public DateTime NextDay()
        {
            return data.AddDays(1);
        }

        // Метод для определения, сколько дней осталось до конца месяца
        public int DaysLeft()
        {
            DateTime lastDayOfMonth = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            return (lastDayOfMonth - data).Days;
        }
    }
}

