using System;

namespace OOP_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Приветствие и ввод строк и столбцов
            char[] Chars = { ' ', ',', '.', '/' };
            Console.WriteLine("Привет, пользователь!\nТебе нужно указать количество строк и стобцов для массива\nОдной строкой напиши два числа\nПервое число - количество строк, Второе - количество столбцов");
            Console.WriteLine("Числа нужно указывать через один из следующих разделителей: '(пробел)' ',' '.' '/' ");
            Console.WriteLine("Например - 5.2. - где 5 - это кол-во строк, а 2 - кол-во столбцов");
            Console.WriteLine();
            Console.WriteLine("Введите кол-во строк и стобцов");

            string text = Console.ReadLine();

            string[] numbers = text.Split(Chars);

            int nrow =  Convert.ToInt32(numbers[0]);

            int ncolumn = Convert.ToInt32(numbers[1]);

            #endregion

            #region Метод Main() Пункт 1
            ResearchTeam newteam = new ResearchTeam("Как копирайтить", "Копирайтилка", 1110003, ResearchTeam.TimeFrame.Year);

            newteam.List = new Paper[nrow * ncolumn];
            newteam.ToShortString();
            #endregion

            #region Метод Main() Пункт 2
            Console.WriteLine(newteam[ResearchTeam.TimeFrame.Year]);
            Console.WriteLine(newteam[ResearchTeam.TimeFrame.Long]);
            Console.WriteLine(newteam[ResearchTeam.TimeFrame.TwoYaers]);

            Console.WriteLine();
            #endregion

            #region Метод Main() Пункт 3
            newteam.Research_name = "Как сдать лабу??";
            newteam.Org_name = "Ассоциация Ленкиса Фёдора БСБО-16-20";
            newteam.Reg_id = 1337228;
            newteam.Time = ResearchTeam.TimeFrame.Long;

            Console.WriteLine(newteam.Research_name.ToString());
            Console.WriteLine(newteam.Org_name.ToString());    
            Console.WriteLine(newteam.Reg_id.ToString());   
            Console.WriteLine(newteam.Time.ToString());
            #endregion

            #region Метод Main() Пункт 4
            Person person = new Person("Фёдор", "Ленкис", new DateTime(2002, 03, 11));

            newteam.AddPapers(new Paper("Лаба", person, new DateTime(2021, 09, 15)));

            newteam.ToString();
            #endregion

            #region Метод Main() Пункт 5
            Console.WriteLine(newteam.Latest);
            #endregion

            #region Метод Main() Пункт 6
            int start1 = Environment.TickCount;
            Paper[] first = new Paper[nrow * ncolumn];//Одномерный массив
            for (int i = 0; i < nrow*ncolumn; i++)
            {
                first[i] = new Paper("Попытка первая", person, new DateTime(2021, 11, 11));
            }
            int end1 = Environment.TickCount;
            int result1 = end1 - start1;
            Console.WriteLine($"С одномерным массивом программа работала {result1} милисекунд или {result1/1000} секунд") ;

            int start2 = Environment.TickCount;
            Paper[,] second = new Paper[nrow, ncolumn];//Двумерный массив
            for (int i = 0; i < nrow; i++)
            {
                for (int k = 0; k < ncolumn; k++)
                {
                    second[i,k] = new Paper("Попытка вторая", person, new DateTime(2021, 11, 11));
                }
               
            }
            int end2 = Environment.TickCount;
            int result2 = end2 - start2;
            Console.WriteLine($"С двумерным массивом программа работала {result2} милисекунд или {result2 / 1000} секунд");

            int start3 = Environment.TickCount;
            Paper[][] third = new Paper[nrow][];// массив массивов
            for (int i = 0; i < nrow; i++)
            {
                third[i] = new Paper[ncolumn];
                for (int k = 0; k < ncolumn; k++)
                {
                    third[i][k] = new Paper("Попытка третья", person, new DateTime(2021, 11, 11));
                }

            }
            int end3 = Environment.TickCount;
            int result3 = end3 - start3;
            Console.WriteLine($"С двумерным массивом программа работала {result3} милисекунд или {result3 / 1000} секунд");
            #endregion
        }

    }
}
