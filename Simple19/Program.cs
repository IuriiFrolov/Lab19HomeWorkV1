using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19Lesson19
{
    class Door
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Hight { get; set; }
        public int Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Material { get; set; }
        public List<string> Composition { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Door> listDoor = new List<Door>()
            {
                new Door(){ Id=1, Width=1000, Hight=2000, Cost= 100000, Manufacturer="Заря",Material="Металл", Composition=new List<string>(){"Полотно","Коробка","Ручка","Петли","Глазок","Замок" } },
                new Door(){ Id=2, Width=1000, Hight=2000, Cost= 700, Manufacturer="Москва",Material="Дерево", Composition=new List<string>(){"Полотно","Коробка","Ручка","Петли","Глазок","Замок" } },
                new Door(){ Id=3, Width=1000, Hight=2000, Cost= 7200, Manufacturer="Билд",Material="Пластик", Composition=new List<string>(){"Полотно","Коробка","Ручка","Петли","Глазок","Замок" } },
                new Door(){ Id=4, Width=1000, Hight=2000, Cost= 1500, Manufacturer="Ростов",Material="Дерево", Composition=new List<string>(){"Полотно","Коробка","Ручка","Петли","Глазок","Замок" } },
                new Door(){ Id=5, Width=1000, Hight=2000, Cost= 900, Manufacturer="Казань",Material="Металл", Composition=new List<string>(){"Полотно","Коробка","Ручка","Петли","Глазок","Замок" } },
                new Door(){ Id=6, Width=1000, Hight=2000, Cost= 3000, Manufacturer="Билд",Material="Пластик", Composition=new List<string>(){"Полотно","Коробка","Ручка","Петли","Глазок","Замок" } },
                new Door(){ Id=7, Width=1000, Hight=2000, Cost= 1700, Manufacturer="Заря",Material="Металл", Composition=new List<string>(){"Полотно","Коробка","Ручка","Петли","Глазок","Замок" } },
                new Door(){ Id=8, Width=1000, Hight=2000, Cost= 15000, Manufacturer="Заря",Material="Дерево", Composition=new List<string>(){"Полотно","Коробка","Ручка","Петли","Глазок","Замок" } },
                new Door(){ Id=9, Width=1000, Hight=2000, Cost= 18000, Manufacturer="Заря",Material="Металл", Composition=new List<string>(){"Полотно","Коробка","Ручка","Петли","Глазок","Замок" } },
                new Door(){ Id=10, Width=1000, Hight=2000, Cost= 3000, Manufacturer="Заря",Material="Дерево" },

            };
            //List<Door> doors = (from d in listDoor
            //                    orderby d.Material , d.Id
            //                    select d).ToList();

            var doors = listDoor
                .Any(d => d.Cost >= 1000);

            Console.WriteLine("Есть ли боьше 30 ? {0}", doors);




            //foreach (var d in doors)
            //    Console.WriteLine($"{d.Id}, {d.Width}, {d.Hight}, {d.Cost}, {d.Manufacturer}, {d.Material}");
            Console.ReadKey();


            #region HomeWork
            /* Console.Write("Введите название процессора: ");
             string t = Convert.ToString (Console.ReadLine());
             List<Door> doors = listDoor.Where(d => d.Manufacturer == t).ToList();*/
            /*Console.Write("Введите минимаьный объем ОЗУ ");
            int t = Convert.ToInt32(Console.ReadLine());
            List<Door> doors = listDoor.Where(d => d.Cost >= t).ToList();*/


            /*List<Door> doors = (from d in listDoor
                                orderby d.Cost
                                select d).ToList();*/
            //Это для типа сгруппированного
            //List<Door> doors = (from d in listDoor
            //                    orderby d.Material, d.Id
            //                    select d).ToList();
            ////Это для Foreach
            //Foreach (var d in doors)
            //Console.WriteLine($"{d.Id}, {d.Width}, {d.Hight}, {d.Cost}, {d.Manufacturer}, {d.Material}");

            //var doors = listDoor
            //    .Max(d => d.Cost);
            //Console.WriteLine("Max = {0}", doors);
            //var doors = listDoor
            //    .Min(d => d.Cost);
            //Console.WriteLine("Min = {0}", doors);
            // Последний вопрос!
            //var doors = listDoor
            //    .Any(d => d.Cost >= 1000);

            //Console.WriteLine("Есть ли боьше 30 ? {0}", doors);



            //List<Door> doors = listDoor.Max(d => d.Cost).ToList(); не работает

            #endregion
        }
    }
}

