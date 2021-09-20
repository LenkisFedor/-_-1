using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab1
{
    class ResearchTeam
    {
        public enum TimeFrame {Year, TwoYaers, Long };

        #region Конструкторы
        public ResearchTeam(string research_name, string org_name, int reg_id, TimeFrame time)
        {
            _research_name = research_name; // название темы исследования
            _reg_id = reg_id; // регистрационный номер
            _org_name = org_name;// название организации
            _time = time;//продолжительность исследования
        }

        public ResearchTeam()
        {
            _research_name = "Неизвестно";
            _org_name = "Неизвестно";
            _reg_id = 000;
            _time = TimeFrame.Long;
        }

        #endregion

        #region Поля
        private string _research_name;

        private string _org_name;

        private int _reg_id;

        private Paper[] _list;

        private TimeFrame _time;

        #endregion

        #region Свойства
        public string Research_name
        {
            get { return _research_name; }
            set { _research_name = value; }
        }

        public string Org_name
        {
            get { return _org_name; }
            set { _org_name = value; }
        }

        public int Reg_id
        {
            get { return _reg_id; }
            set { _reg_id = value; }
        }

        public Paper[] List
        {
            get { return _list; }
            set { _list = value; }
        }

        public TimeFrame Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public Paper Latest
        {
            get
            {
                int MaxIndex = 0;
                DateTime Max = new DateTime(0001,01,01);
                if (List[0] == null) return null;
                else
                for (int i = 0; i < List.Length; i++)
                {
                    if (List[i] == null) break;
                    if(Max < List[i].Date) 
                    { 
                        Max = List[i].Date;
                        MaxIndex = i;
                    }
                }
                return List[MaxIndex];
            }
        }
        #endregion

        #region Индексатор
        public bool this[TimeFrame TimeIndex]
        {
            get
            {
                if (Time == TimeIndex) return true;
                else return false;
            }
        }
        #endregion

        #region Методы
        public void AddPapers(params Paper[] Addedpaper)
        {
            for (int i = 0; i < List.Length; i++)
            {
                if (List[i] == null)
                {
                    List[i] = Addedpaper[0];
                    break;
                }
            }
        }

        public override string ToString()
        {
           string Info = $"Тема исследования: {Research_name}\nНазвание организации: {Org_name}\nРегистрационный номер: {Reg_id}\nПродолжительность ииследования: {Time}\n";
            Console.WriteLine();
            Console.WriteLine(Info);
            Console.WriteLine("Списпок публикаций : ");
            if (List[0] != null)
            {
                for (int i = 0; i < List.Length; i++)
                {
                    if (List[i] != null) Console.WriteLine(List[i]);
                }
                Console.WriteLine();
                return Info;
            }
            else
            {
                Console.WriteLine("Список пуст");
                return null;
            }

        }

        public virtual string ToShortString()
        {
            string ShortInfo = $"Тема исследования: {Research_name}\nНазвание организации: {Org_name}\nРегистрационный номер: {Reg_id}\nПродолжительность ииследования: {Time}\n";
            Console.WriteLine(ShortInfo);
            return ShortInfo;
        }
        #endregion
    }
}
