using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vars_sabitler_
{
    class Program
    {
        static void Main(string[] args)
        {
            // static ve const beraber kullanılmaz
            //static const int c = 23; (yanlış kullanım)

            // sabitler sabitlere katılabilir


            // sabitlere oluşturulduğu yerde değeri verilmelidir
            // const int c1;
            // c1=3;


            //Console.WriteLine(c1);



        }

        readonly int c1;

        public Program()
        {
            c1 = 3;
        }

    }
}
