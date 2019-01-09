using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Equivalency_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

            AlgoritmoPruebas.SetMinimoKcal = 1300;
            AlgoritmoPruebas.SetMaximoKcal = 2300;
            AlgoritmoPruebas.SetPorcentajePRO = 15;
            AlgoritmoPruebas.SetPorcentajeLIP = 25;
            AlgoritmoPruebas.SetPorcentajeCHO = 60;
            AlgoritmoPruebas.SetCalculos = 0;
            AlgoritmoPruebas.SetRangoKcal = 5;

            AlgoritmoPruebas.AlgoritmoEquivalencias();

            timer.Stop();
            Console.WriteLine(String.Format("Tiempo = {0}", timer.Elapsed));

            Console.ReadKey();
        }
    }
}
