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
            string sDir ="D:\\Skillfactory\\Del\\";
            Cleaner clean = new Cleaner();
            clean.DelOldFiles(sDir);


        }
    }
}
