using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab1
{
    class Paper
    {
        #region Конструкторы
        public Paper(string name, Person person, DateTime date)
        {
            Name = name; //название публикации
            Person = person; //автор публикации
            Date = date; // дата публикации
        }

        public Paper()
        {
            Name = "Неизвестно";
            Person = new Person("Неизвестно", "Неизвестно", new DateTime(0000, 00, 00));
            Date = new DateTime(0001, 01, 01);
        }
        #endregion

        #region Методы
        public override string ToString()
        {
            Console.WriteLine();
            return string.Format("  Название публикации - " + Name.ToString() + "\n  Автор - " + Person.ToString() + "\n  Дата публикации - " + Date.ToString("D"));
        }
        #endregion

        #region Свойства
        public string Name { get; set; }
        public Person Person { get; set; }
        public DateTime Date { get; set; }
        #endregion
    }
}
