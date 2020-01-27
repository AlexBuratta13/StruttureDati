using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StruttureDati
{
    class Program
    {
        private const string File = @"FileLista.txt";
        private const string File1 = @"FileTesto.txt";
        static void Main(string[] args)
        {
            List<double> listaNumeri = new List<double>();
            using (StreamReader srFile = new StreamReader("FileLista.txt"))
            {
                string line;
                while ((line = srFile.ReadLine())!= null)
                {
                    listaNumeri.Add(double.Parse(line));
                }
            }
            using (StreamWriter swFile1 = new StreamWriter("fileTesto.txt"))
            {
                for(int i = listaNumeri.Count-1; i >= 0; i--)
                {
                    swFile1.WriteLine(listaNumeri[i]);
                }
                swFile1.Flush();
            }
        }
    }
}
