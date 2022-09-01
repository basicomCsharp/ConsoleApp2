using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)            
        {
            string sDir ="";
            Console.WriteLine("Введите каталог для удаления файлов, \n которые не использовались более 30 минут в формате \n имя_диска\\:каталог\\подкаталог для удаления");
            do
            {
                sDir = Console.ReadLine();
                if (Directory.Exists(sDir))
                {
                    Cleaner clean = new Cleaner();
                    clean.DelOldFolder(sDir);
                    break;
                }
                else
                {
                    Console.WriteLine("Каталог не существует или некорректно указан. \n Повторите попытку.");                    
                }
            }
            while (true);
            Console.WriteLine("Программа успешно выполнила задачу.");
            Console.ReadKey();
        }
    }
}
