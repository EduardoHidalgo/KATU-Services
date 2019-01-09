using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equivalency_Calculator
{
    class ContenedorPruebas
    {
        public static string[] Groups;
        public static int[] Energy;
        public static double[] Prot;
        public static double[] Lip;
        public static double[] Cho;

        public static double[] GroupKcal;
        public static double[] GroupProt;
        public static double[] GroupLip;
        public static double[] GroupCho;

        public static int[] Porciones;

        public static int[] MinPorciones;
        public static int[] MaxPorciones;

        public static int MínimoKcal = 0;
        public static int MáximoKcal = 0;

        public static int PROPorc = 0;
        public static int LIPPorc = 0;
        public static int CHOPorc = 0;

        public static double PROGr = 0;
        public static double LIPGr = 0;
        public static double CHOGr = 0;
        public static double PROKcal = 0;
        public static double LIPKcal = 0;
        public static double CHOKcal = 0;

        public static double PROGr_min = 0;
        public static double LIPGr_min = 0;
        public static double CHOGr_min = 0;
        public static double PROGr_max = 0;
        public static double LIPGr_max = 0;
        public static double CHOGr_max = 0;


        public static int Cálculos
             = 0;
        public static double IndiceKcal = 0;
        public static double IndicePROGr = 0;
        public static double IndiceLIPGr = 0;
        public static double IndiceCHOGr = 0;

        public static double Kcal = 0;
        public static double Kcal_min = 0;
        public static double Kcal_max = 0;

        static string Group1 = "Verduras"; //REQUERIDO
        static string Group2 = "Frutas"; //REQUERIDO
        static string Group3 = "CYT s/g"; //REQUERIDO
        static string Group4 = "AOA bajo"; //REQUERIDO
        static string Group5 = "AOA medio"; //REQUERIDO
        static string Group6 = "Aceites s/p"; //REQUERIDO

        static int Energy1 = 25;
        static int Energy2 = 60;
        static int Energy3 = 70;
        static int Energy4 = 55;
        static int Energy5 = 75;
        static int Energy6 = 45;

        static double Prot1 = 2;
        static double Prot2 = 0;
        static double Prot3 = 2;
        static double Prot4 = 7;
        static double Prot5 = 7;
        static double Prot6 = 0;

        static double Lip1 = 0;
        static double Lip2 = 0;
        static double Lip3 = 0;
        static double Lip4 = 3;
        static double Lip5 = 5;
        static double Lip6 = 5;

        static double Cho1 = 4;
        static double Cho2 = 15;
        static double Cho3 = 15;
        static double Cho4 = 0;
        static double Cho5 = 0;
        static double Cho6 = 0;

        static int MinPorcion1 = 1;
        static int MinPorcion2 = 1;
        static int MinPorcion3 = 1;
        static int MinPorcion4 = 1;
        static int MinPorcion5 = 1;
        static int MinPorcion6 = 1;

        static int MaxPorcion1 = 15;
        static int MaxPorcion2 = 15;
        static int MaxPorcion3 = 8;
        static int MaxPorcion4 = 5;
        static int MaxPorcion5 = 5;
        static int MaxPorcion6 = 10;

        public static void CreateArrays()
        {
            Groups = new string[6];
            Energy = new int[6];
            Prot = new double[6];
            Lip = new double[6];
            Cho = new double[6];
            GroupKcal = new double[6];
            GroupProt = new double[6];
            GroupLip = new double[6];
            GroupCho = new double[6];
            Porciones = new int[6];
            MinPorciones = new int[6];
            MaxPorciones = new int[6];

            for (int i = 0; i <= Porciones.Length - 1; i++)
            {
                Porciones[i] = 1;
                GroupKcal[i] = 0;
                GroupProt[i] = 0;
                GroupLip[i] = 0;
                GroupCho[i] = 0;
            }

            Groups[0] = Group1;
            Groups[1] = Group2;
            Groups[2] = Group3;
            Groups[3] = Group4;
            Groups[4] = Group5;
            Groups[5] = Group6;

            Energy[0] = Energy1;
            Energy[1] = Energy2;
            Energy[2] = Energy3;
            Energy[3] = Energy4;
            Energy[4] = Energy5;
            Energy[5] = Energy6;

            Prot[0] = Prot1;
            Prot[1] = Prot2;
            Prot[2] = Prot3;
            Prot[3] = Prot4;
            Prot[4] = Prot5;
            Prot[5] = Prot6;

            Lip[0] = Lip1;
            Lip[1] = Lip2;
            Lip[2] = Lip3;
            Lip[3] = Lip4;
            Lip[4] = Lip5;
            Lip[5] = Lip6;

            Cho[0] = Cho1;
            Cho[1] = Cho2;
            Cho[2] = Cho3;
            Cho[3] = Cho4;
            Cho[4] = Cho5;
            Cho[5] = Cho6;

            MinPorciones[0] = MinPorcion1;
            MinPorciones[1] = MinPorcion2;
            MinPorciones[2] = MinPorcion3;
            MinPorciones[3] = MinPorcion4;
            MinPorciones[4] = MinPorcion5;
            MinPorciones[5] = MinPorcion6;

            MaxPorciones[0] = MaxPorcion1;
            MaxPorciones[1] = MaxPorcion2;
            MaxPorciones[2] = MaxPorcion3;
            MaxPorciones[3] = MaxPorcion4;
            MaxPorciones[4] = MaxPorcion5;
            MaxPorciones[5] = MaxPorcion6;
        }
    }
}
