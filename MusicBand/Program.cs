using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicBand
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            Musicband group;    // группа

            var choice = new ListMusic();
            choice.DataInit();

            Console.WriteLine("\n\t\t Песни");
            Console.WriteLine("\n\t\tГлавное меню:\n");
            Console.WriteLine("\t1 - Просмотр/добавление групп и песен");
            Console.WriteLine("\t2 - Поиск группы");
            Console.WriteLine("\t3 - Поиск песни");
            Console.WriteLine("\t4 - Прямая сортировка (рейтинг)");
            Console.WriteLine("\t5 - Обратная сортировка (рейтинг)");
            Console.Write("\tВыберите = ");
            menu = Console.ReadLine();




        }
    }
}
