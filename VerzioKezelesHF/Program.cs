using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        public static void TombFeltoltes(double[] tomb_be)
        {
            for (int i = 0; i < tomb_be.Length; i++)
            {
                Console.Write("{0}. szám: ",i+1);
                tomb_be[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public static double TombAtlag(double[] tomb_be)
        {
            double szum = 0;
            for (int i = 0; i < tomb_be.Length; i++)
            {
                szum += tomb_be[i];
            }
            return szum / tomb_be.Length;
        }
        static void Main(string[] args)
        {
            //2
            Console.WriteLine("Írj be 10 számot!");
            double[] szamok = new double[10];
            TombFeltoltes(szamok);
            Console.WriteLine("A beírt számok átlaga: "+TombAtlag(szamok));





            Console.ReadKey();
        }
    }
}
