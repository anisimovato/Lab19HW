﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19HW
{
    class PC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Proc { get; set; }
        public string ProcChast { get; set; }
        public int RAM { get; set; }
        public string SSD { get; set; }
        public string VideoMem { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }




    class Program
    {
        static void Main(string[] args)
        {
            List<PC> listPC = new List<PC>()
            {
            new PC() { Id = 1,  Name = "Lenovo",  Proc = "Intel",  ProcChast = "3,0 ГГц",  RAM = 8,  SSD = " SSD=215",  VideoMem = "6 ГБ  ",  Price = 75000,  Count = 10 },
            new PC() { Id = 2,  Name = "Lenovo",  Proc = "Intel",  ProcChast = "3,0 ГГц",  RAM = 8,  SSD = " SSD=256",  VideoMem = "6 ГБ  ",  Price = 70000,  Count = 14 },
            new PC() { Id = 3,  Name = "HP",  Proc = "AMD",  ProcChast = "3,5 ГГц",  RAM = 32,  SSD = " SSD=512",   VideoMem = "4 ГБ  ",  Price = 69000,  Count = 1 },
            new PC() { Id = 4,  Name = "HP",  Proc = "Intel", ProcChast = "3,0 ГГц",  RAM = 16,  SSD = " SSD=256",  VideoMem = "6 ГБ  ",  Price = 78000,  Count = 12 },
            new PC() { Id = 5,  Name = "WD",  Proc = "Intel",  ProcChast = "3,0 ГГц",  RAM = 32,  SSD = " SSD=512",  VideoMem = "4 ГБ  ",  Price = 81000,  Count = 8 },
            new PC() { Id = 6,  Name =  "MSI",  Proc = "AMD",  ProcChast = "3,5 ГГц",  RAM = 16,  SSD = " SSD=512",  VideoMem = "4 ГБ  ",  Price = 73000,  Count = 35 },
            };


            //Console.Write("Укажите название процессора: ");
            //string first = Console.ReadLine();
            //List<PC> proc = (from p in listPC where p.Proc == first select p).ToList();  //-все компьютеры с указанным процессором.
            //foreach (PC p in proc)
            //    Console.WriteLine($"{p.Id}{p.Name}{p.Proc}{p.ProcChast}{p.RAM}{p.SSD}{p.VideoMem}{p.Price}{p.Count}");
            //Console.ReadKey();

            //Console.Write("Укажите минимальный объем оперативной памяти: ");
            //int second = Convert.ToInt32(Console.ReadLine());
            //List<PC> ram = (from p1 in listPC where p1.RAM >= second select p1).ToList(); //все компьютеры с объемом ОЗУ не ниже, чем указано
            //foreach (PC p1 in ram)
            //    Console.WriteLine($"{p1.Id}{p1.Name}{p1.Proc}{p1.ProcChast}{p1.RAM}{p1.SSD}{p1.VideoMem}{p1.Price}{p1.Count}");
            //Console.ReadKey();


            //Console.WriteLine("список, отсортированный по увеличению стоимости: ");
            //var third = (from p2 in listPC orderby p2.Price select p2).ToList();  // по увличению стоимости+++
            //foreach (var p2 in third)
            //    Console.WriteLine($"{p2.Id}{p2.Name}{p2.Proc}{p2.ProcChast}{p2.RAM}{p2.SSD}{p2.VideoMem}{p2.Price}{p2.Count}");
            //Console.ReadKey();




            Console.WriteLine("список, сгруппированный по типу процессора: ");
            var fourth = (from p3 in listPC group p3 by p3.Price select p).ToList();  // по увличению стоимости+++
            foreach (var p3 in fourth)

                Console.WriteLine();
               Console.WriteLine($"{p3.Id}{p3.Name}{p3.Proc}{p3.ProcChast}{p3.RAM}{p3.SSD}{p3.VideoMem}{p3.Price}{p3.Count}");
            Console.ReadKey();









            //var proctipe = (from p in listPC group p by p.Proc);

            //foreach (IGrouping<string, PC> g in proctipe)

            //    Console.WriteLine(g.Key);
            //    foreach (var t in g)
            //        Console.WriteLine(t.Proc);
            //    Console.WriteLine();




            //List<PC> count = (from p in listPC where  p.Count >= 30 select p).ToList(); // кол во больше 30, но не хотяб один...
            //foreach (PC p in count)




            //Console.WriteLine($"{p.Id}{p.Name}{p.Proc}{p.ProcChast}{p.RAM}{p.SSD}{p.VideoMem}{p.Price}{p.Count}");
            //Console.ReadKey();


        }
    }
}


//var proctipe = listPC
//     .GroupBy(p => p.Proc)
//     .ToList();
// foreach(var p in proctipe)



//var proctipe = (from p in listPC group p by p.Proc);
//foreach (var p in proctipe)

//var pc = listPC
//                 .OrderBy(p => p.Price); // по увеличению стоимости
//foreach (var p in pc)


//List<PC> pCs = listPC
//    .Where(p => p.Proc == " Intel")  
//    .ToList();
//foreach (PC p in pCs)



//Модель компьютера  характеризуется  кодом  и  названием  марки компьютера, типом  процессора, частотой  работы  процессора, объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. Создать список, содержащий 6-10 записей с различным набором значений характеристик.

//Определить:

//-все компьютеры с указанным процессором. Название процессора запросить у пользователя;++

//-все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;+++

//-вывести весь список, отсортированный по увеличению стоимости; ++++

//-вывести весь список, сгруппированный по типу процессора;

//-найти самый дорогой и самый бюджетный компьютер;

//-есть ли хотя бы один компьютер в количестве не менее 30 штук?