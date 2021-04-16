using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cor
{
    class FileList
    {
        StreamWriter sw;
        public  void Start(string dir , string file)
        {
            sw = new StreamWriter(file, false, Encoding.Default);
            sw.WriteLine(dir);
            WriteFileList(dir);
            sw.Flush();
            sw.Close();
        }
        private void WriteFileList(string dir)
        {
            string[] dirs;
            try
            {
                dirs = Directory.GetDirectories(dir);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("出现错误,目录损坏或无权访问!\n" + dir, "错误警告");
                throw;
            }
            string[] files = Directory.GetFiles(dir);
            for (int i = 0; i < dirs.Length; i++)
            {
                sw.WriteLine(dirs[i]);
                WriteFileList(dirs[i]);

            }
            for (int i = 0; i < files.Length; i++)
            {
                sw.WriteLine(files[i]);
            }
        }
    }
}