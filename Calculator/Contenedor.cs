using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Contenedor
    {
        //Arrays de los grupos alimenticios
        public static string[] Groups;
        public static int[] Energy;
        public static double[] Prot;
        public static double[] Lip;
        public static double[] Cho;

        //Arrays de los Subtotales
        public static double[] GroupKcal;
        public static double[] GroupProt;
        public static double[] GroupLip;
        public static double[] GroupCho;

        //Array de las porciones
        public static int[] Porciones;

        //Mínimos, Máximos
        public static int[] MinPorciones;
        public static int[] MaxPorciones;

        //Array de Booleanos
        public static bool[] Restricciones;

        //Mínimo de Kcal y Máximo de Kcal
        public static int MínimoKcal = 0;
        public static int MáximoKcal = 0;

        //Porcentajes
        public static int PROPorc = 0;
        public static int LIPPorc = 0;
        public static int CHOPorc = 0;

        //Gramos
        public static double PROGr = 0;
        public static double LIPGr = 0;
        public static double CHOGr = 0;
        public static double PROKcal = 0;
        public static double LIPKcal = 0;
        public static double CHOKcal = 0;

        //Mínimos y Máximos de gramos
        public static double PROGr_min = 0;
        public static double LIPGr_min = 0;
        public static double CHOGr_min = 0;
        public static double PROGr_max = 0;
        public static double LIPGr_max = 0;
        public static double CHOGr_max = 0;

        //Índices
        public static int Cálculos = 0;
        public static double IndiceKcal = 0;
        public static double IndicePROGr = 0;
        public static double IndiceLIPGr = 0;
        public static double IndiceCHOGr = 0;

        //Kcal
        public static double Kcal = 0;
        public static double Kcal_min = 0;
        public static double Kcal_max = 0;

        //Base de Datos Estática

        static string Group1 = "Verduras"; //REQUERIDO
        static string Group2 = "Frutas"; //REQUERIDO
        static string Group3 = "CYT s/g"; //REQUERIDO
        static string Group4 = "CYT c/g";
        static string Group5 = "Leguminosas";
        static string Group6 = "AOA muy bajo";
        static string Group7 = "AOA bajo"; //REQUERIDO
        static string Group8 = "AOA medio"; //REQUERIDO
        static string Group9 = "AOA alto";
        static string Group10 = "Leche S";
        static string Group11 = "Leche SD";
        static string Group12 = "Leche E";
        static string Group13 = "Leche c/A";
        static string Group14 = "Aceites s/p"; //REQUERIDO
        static string Group15 = "Aceites c/p";
        static string Group16 = "Azúcar c/g";
        static string Group17 = "Azúcar s/g";

        static int Energy1 = 25;
        static int Energy2 = 60;
        static int Energy3 = 70;
        static int Energy4 = 115;
        static int Energy5 = 120;
        static int Energy6 = 40;
        static int Energy7 = 55;
        static int Energy8 = 75;
        static int Energy9 = 100;
        static int Energy10 = 95;
        static int Energy11 = 110;
        static int Energy12 = 150;
        static int Energy13 = 200;
        static int Energy14 = 45;
        static int Energy15 = 70;
        static int Energy16 = 40;
        static int Energy17 = 85;

        static double Prot1 = 2;
        static double Prot2 = 0;
        static double Prot3 = 2;
        static double Prot4 = 2;
        static double Prot5 = 8;
        static double Prot6 = 7;
        static double Prot7 = 7;
        static double Prot8 = 7;
        static double Prot9 = 7;
        static double Prot10 = 9;
        static double Prot11 = 9;
        static double Prot12 = 9;
        static double Prot13 = 8;
        static double Prot14 = 0;
        static double Prot15 = 3;
        static double Prot16 = 0;
        static double Prot17 = 0;

        static double Lip1 = 0;
        static double Lip2 = 0;
        static double Lip3 = 0;
        static double Lip4 = 5;
        static double Lip5 = 1;
        static double Lip6 = 1;
        static double Lip7 = 3;
        static double Lip8 = 5;
        static double Lip9 = 8;
        static double Lip10 = 2;
        static double Lip11 = 4;
        static double Lip12 = 8;
        static double Lip13 = 5;
        static double Lip14 = 5;
        static double Lip15 = 5;
        static double Lip16 = 0;
        static double Lip17 = 5;

        static double Cho1 = 4;
        static double Cho2 = 15;
        static double Cho3 = 15;
        static double Cho4 = 15;
        static double Cho5 = 20;
        static double Cho6 = 0;
        static double Cho7 = 0;
        static double Cho8 = 0;
        static double Cho9 = 0;
        static double Cho10 = 12;
        static double Cho11 = 12;
        static double Cho12 = 12;
        static double Cho13 = 30;
        static double Cho14 = 0;
        static double Cho15 = 3;
        static double Cho16 = 10;
        static double Cho17 = 10;

        static int MinPorcion1 = 1;
        static int MinPorcion2 = 1;
        static int MinPorcion3 = 1;
        static int MinPorcion4 = 0;
        static int MinPorcion5 = 0;
        static int MinPorcion6 = 0;
        static int MinPorcion7 = 1;
        static int MinPorcion8 = 1;
        static int MinPorcion9 = 0;
        static int MinPorcion10 = 0;
        static int MinPorcion11 = 0;
        static int MinPorcion12 = 0;
        static int MinPorcion13 = 0;
        static int MinPorcion14 = 1;
        static int MinPorcion15 = 0;
        static int MinPorcion16 = 0;
        static int MinPorcion17 = 0;

        static int MaxPorcion1 = 15;
        static int MaxPorcion2 = 15;
        static int MaxPorcion3 = 8;
        static int MaxPorcion4 = 7;
        static int MaxPorcion5 = 5;
        static int MaxPorcion6 = 5;
        static int MaxPorcion7 = 5;
        static int MaxPorcion8 = 5;
        static int MaxPorcion9 = 5;
        static int MaxPorcion10 = 5;
        static int MaxPorcion11 = 5;
        static int MaxPorcion12 = 5;
        static int MaxPorcion13 = 5;
        static int MaxPorcion14 = 5;
        static int MaxPorcion15 = 5;
        static int MaxPorcion16 = 7;
        static int MaxPorcion17 = 3;

        static bool Restriccion1 = false;
        static bool Restriccion2 = false;
        static bool Restriccion3 = false;
        static bool Restriccion4 = true;
        static bool Restriccion5 = true;
        static bool Restriccion6 = true;
        static bool Restriccion7 = false;
        static bool Restriccion8 = false;
        static bool Restriccion9 = true;
        static bool Restriccion10 = true;
        static bool Restriccion11 = true;
        static bool Restriccion12 = true;
        static bool Restriccion13 = true;
        static bool Restriccion14 = false;
        static bool Restriccion15 = true;
        static bool Restriccion16 = true;
        static bool Restriccion17 = true;

        public static void CreateArrays()
        {
            Groups = new string[17];
            Energy = new int[17];
            Prot = new double[17];
            Lip = new double[17];
            Cho = new double[17];
            GroupKcal = new double[17];
            GroupProt = new double[17];
            GroupLip = new double[17];
            GroupCho = new double[17];
            Porciones = new int[17];
            MinPorciones = new int[17];
            MaxPorciones = new int[17];
            Restricciones = new bool[17];

            for (int i = 0; i <= Porciones.Length - 1; i++)
            {
                Porciones[i] = 0;
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
            Groups[6] = Group7;
            Groups[7] = Group8;
            Groups[8] = Group9;
            Groups[9] = Group10;
            Groups[10] = Group11;
            Groups[11] = Group12;
            Groups[12] = Group13;
            Groups[13] = Group14;
            Groups[14] = Group15;
            Groups[15] = Group16;
            Groups[16] = Group17;

            Energy[0] = Energy1;
            Energy[1] = Energy2;
            Energy[2] = Energy3;
            Energy[3] = Energy4;
            Energy[4] = Energy5;
            Energy[5] = Energy6;
            Energy[6] = Energy7;
            Energy[7] = Energy8;
            Energy[8] = Energy9;
            Energy[9] = Energy10;
            Energy[10] = Energy11;
            Energy[11] = Energy12;
            Energy[12] = Energy13;
            Energy[13] = Energy14;
            Energy[14] = Energy15;
            Energy[15] = Energy16;
            Energy[16] = Energy17;

            Prot[0] = Prot1;
            Prot[1] = Prot2;
            Prot[2] = Prot3;
            Prot[3] = Prot4;
            Prot[4] = Prot5;
            Prot[5] = Prot6;
            Prot[6] = Prot7;
            Prot[7] = Prot8;
            Prot[8] = Prot9;
            Prot[9] = Prot10;
            Prot[10] = Prot11;
            Prot[11] = Prot12;
            Prot[12] = Prot13;
            Prot[13] = Prot14;
            Prot[14] = Prot15;
            Prot[15] = Prot16;
            Prot[16] = Prot17;

            Lip[0] = Lip1;
            Lip[1] = Lip2;
            Lip[2] = Lip3;
            Lip[3] = Lip4;
            Lip[4] = Lip5;
            Lip[5] = Lip6;
            Lip[6] = Lip7;
            Lip[7] = Lip8;
            Lip[8] = Lip9;
            Lip[9] = Lip10;
            Lip[10] = Lip11;
            Lip[11] = Lip12;
            Lip[12] = Lip13;
            Lip[13] = Lip14;
            Lip[14] = Lip15;
            Lip[15] = Lip16;
            Lip[16] = Lip17;

            Cho[0] = Cho1;
            Cho[1] = Cho2;
            Cho[2] = Cho3;
            Cho[3] = Cho4;
            Cho[4] = Cho5;
            Cho[5] = Cho6;
            Cho[6] = Cho7;
            Cho[7] = Cho8;
            Cho[8] = Cho9;
            Cho[9] = Cho10;
            Cho[10] = Cho11;
            Cho[11] = Cho12;
            Cho[12] = Cho13;
            Cho[13] = Cho14;
            Cho[14] = Cho15;
            Cho[15] = Cho16;
            Cho[16] = Cho17;

            MinPorciones[0] = MinPorcion1;
            MinPorciones[1] = MinPorcion2;
            MinPorciones[2] = MinPorcion3;
            MinPorciones[3] = MinPorcion4;
            MinPorciones[4] = MinPorcion5;
            MinPorciones[5] = MinPorcion6;
            MinPorciones[6] = MinPorcion7;
            MinPorciones[7] = MinPorcion8;
            MinPorciones[8] = MinPorcion9;
            MinPorciones[9] = MinPorcion10;
            MinPorciones[10] = MinPorcion11;
            MinPorciones[11] = MinPorcion12;
            MinPorciones[12] = MinPorcion13;
            MinPorciones[13] = MinPorcion14;
            MinPorciones[14] = MinPorcion15;
            MinPorciones[15] = MinPorcion16;
            MinPorciones[16] = MinPorcion17;

            MaxPorciones[0] = MaxPorcion1;
            MaxPorciones[1] = MaxPorcion2;
            MaxPorciones[2] = MaxPorcion3;
            MaxPorciones[3] = MaxPorcion4;
            MaxPorciones[4] = MaxPorcion5;
            MaxPorciones[5] = MaxPorcion6;
            MaxPorciones[6] = MaxPorcion7;
            MaxPorciones[7] = MaxPorcion8;
            MaxPorciones[8] = MaxPorcion9;
            MaxPorciones[9] = MaxPorcion10;
            MaxPorciones[10] = MaxPorcion11;
            MaxPorciones[11] = MaxPorcion12;
            MaxPorciones[12] = MaxPorcion13;
            MaxPorciones[13] = MaxPorcion14;
            MaxPorciones[14] = MaxPorcion15;
            MaxPorciones[15] = MaxPorcion16;
            MaxPorciones[16] = MaxPorcion17;

            Restricciones[0] = Restriccion1;
            Restricciones[1] = Restriccion2;
            Restricciones[2] = Restriccion3;
            Restricciones[3] = Restriccion4;
            Restricciones[4] = Restriccion5;
            Restricciones[5] = Restriccion6;
            Restricciones[6] = Restriccion7;
            Restricciones[7] = Restriccion8;
            Restricciones[8] = Restriccion9;
            Restricciones[9] = Restriccion10;
            Restricciones[10] = Restriccion11;
            Restricciones[11] = Restriccion12;
            Restricciones[12] = Restriccion13;
            Restricciones[13] = Restriccion14;
            Restricciones[14] = Restriccion15;
            Restricciones[15] = Restriccion16;
            Restricciones[16] = Restriccion17;
        }
    }
}