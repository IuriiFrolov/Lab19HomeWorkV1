using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19HomeWorkV1
{
    class Computer
    {
        public int Id { get; set; } // код компьютера
        public string Name { get; set; } // Марка компьютера
        public string TypeProcessor { get; set; } // тип процессора
        public double ProcessorFrequencyGHz { get; set; } // частота процессора
        public double RAMCapacityGb { get; set; } // ОЗУ, объем оперативнй памяти
        public int HardDiskCapacityGb { get; set; }// объем жесткого диска
        public int VideoCardMemoryCapacityGb { get; set; } // объем памяти видеокарты
        public double Cost { get; set; }// стоимость
        public int InStock { get; set; }// количество в наличии

    }
    class Program
    {
        static void Main(string[] args)
        {// список с 6 записями 
            List<Computer> listComputers = new List<Computer>()
            {
                new Computer(){ Id=1, Name = "CityLine", TypeProcessor ="IntelCore I5", ProcessorFrequencyGHz =3.00, RAMCapacityGb=8.00, HardDiskCapacityGb= 464, VideoCardMemoryCapacityGb= 4, Cost=39000, InStock = 10 },
                new Computer(){ Id=2, Name = "Lenovo", TypeProcessor ="IntelCore I3", ProcessorFrequencyGHz =2.00, RAMCapacityGb=6.00, HardDiskCapacityGb= 1024, VideoCardMemoryCapacityGb= 3, Cost=31000, InStock = 30 } ,
                new Computer(){ Id=3, Name = "Asus", TypeProcessor ="IntelCore I7", ProcessorFrequencyGHz =4.00, RAMCapacityGb=16.00, HardDiskCapacityGb= 512, VideoCardMemoryCapacityGb= 3, Cost=54000, InStock = 29 },
               new Computer(){ Id=4, Name = "CityLine", TypeProcessor ="IntelCore I3", ProcessorFrequencyGHz =2.00, RAMCapacityGb=16.00, HardDiskCapacityGb= 512, VideoCardMemoryCapacityGb= 4, Cost=60000, InStock = 8 },
                new Computer(){ Id=5, Name = "Lenovo", TypeProcessor ="IntelCore I7", ProcessorFrequencyGHz =3.00, RAMCapacityGb=16.00, HardDiskCapacityGb= 256, VideoCardMemoryCapacityGb= 2, Cost=25000, InStock = 21 } ,
                new Computer(){ Id=6, Name = "Asus", TypeProcessor ="IntelCore I5", ProcessorFrequencyGHz =3.00, RAMCapacityGb=8.00, HardDiskCapacityGb= 512, VideoCardMemoryCapacityGb= 3, Cost=44000, InStock = 27 },
            };

            #region все компьютеры с указанным процессором. Название процессора запросить у пользователя
            Console.Write("Введите название процессора: ");
            string typeProcessor = Convert.ToString(Console.ReadLine());
            List<Computer> computers = listComputers
               .Where(d => d.TypeProcessor == typeProcessor)
               .ToList();
            foreach (var d in computers)
                Console.WriteLine($" № {d.Id}, Производитель: {d.Name},Тип процессора: {d.TypeProcessor} ");
            Console.WriteLine();
            #endregion

            #region все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
            Console.Write("Введите минимальный объем (Гб) оперативной памяти : ");
            int ramCapacityGb = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers1 = listComputers
               .Where(d => d.RAMCapacityGb >= ramCapacityGb)
               .ToList();
            foreach (var d in computers1)
                Console.WriteLine($" № {d.Id}, Производитель: {d.Name}, Объем ОЗУ: {d.RAMCapacityGb} ");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region вывести весь список, отсортированный по увеличению стоимости;

            Console.WriteLine("Выводим весь список, отсортированный по увеличению стоимости: ");
            List<Computer> computers2 = (from d in listComputers
                                         orderby d.Cost
                                         select d).ToList();
            foreach (var d in computers2)
                Console.WriteLine($" № {d.Id}, Производитель: {d.Name}, Стоимость: {d.Cost} ");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region вывести весь список, сгруппированный по типу процессора;
            Console.WriteLine("Выводим весь список, сгруппированный по типу процессора: ");
            List<Computer> computers3 = (from d in listComputers
                                         orderby d.TypeProcessor, d.Id
                                         select d).ToList();
            foreach (var d in computers3)
                Console.WriteLine($"Тип процессора: {d.TypeProcessor} № {d.Id}, Производитель: {d.Name}, Стоимость: {d.Cost} ");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region найти самый дорогой и самый бюджетный компьютер;
            var computers4 = listComputers
                .Max(d => d.Cost);
            Console.WriteLine($"Самый дорогой компьютер стоит: {computers4}");
            var computers5 = listComputers
                .Min(d => d.Cost);
            Console.WriteLine($"Самый бюджетный компьютер стоит: {computers5}");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region есть ли хотя бы один компьютер в количестве не менее 30 штук?
            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук? ");
                        var computers6 = listComputers
                .Any(d => d.InStock >= 30);
            if (true)
            {
                Console.WriteLine("Да, есть.");
            }
            else { Console.WriteLine("Нет, нету."); }
            #endregion

            Console.ReadKey();


        }
    }
}
