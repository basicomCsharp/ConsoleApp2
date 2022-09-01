using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Cleaner
    {
        public static string DirName { get; set; }
        private static TimeSpan ts;
        private void DelFile(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            foreach (string s in files)
            {
                var fileInfo = new FileInfo(s);
                ts = DateTime.Now - fileInfo.LastWriteTime;
                if (ts.Minutes > 30)
                    fileInfo.Delete();
            }
        }
        public void DelOldFiles(string dir)
        {
            DirName = dir;
            if (Directory.Exists(DirName))
            {
                DelFile(DirName);
                string[] dirs = Directory.GetDirectories(DirName);
                foreach (string d in dirs)
                {
                    DelFile(d);
                    DelOldFiles(d);
                }                   
            }
        }
    }
}
