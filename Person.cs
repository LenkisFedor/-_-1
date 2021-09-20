using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab1
{
    class Person
    {

        #region fields
        private string _name;
        private string _surname;
        private DateTime _date = new DateTime();
        #endregion

        #region properies
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
       
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int YearBirth
        {
            get { return Date.Year; }
            set { Date = Date.AddYears(YearBirth - Date.Year); }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        #endregion

        #region constructors
        public Person(string name, string surname, DateTime date)
        {
            _name = name;
            _date = date;
            _surname = surname;
        }

        public Person()
        {
            _name = "Неизвестно";
            _surname = "Неизвестно";
            _date = new DateTime();
        }
        #endregion

        #region Methods
        public virtual string ToShortString(string fullname)
        {
            return  $"Имя :{_name} Фамилия :{_surname}"; 
        }

        public override string ToString()
        {
            Console.WriteLine();
            return string.Format("Имя :" + _name.ToString() + "\n\t  Фамилия :" + _surname.ToString() + "\n\t  Дата рождения :" + _date.ToString("D"));
        }
        #endregion

    }
}
