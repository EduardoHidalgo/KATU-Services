using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equivalency_Calculator
{
    class AlgoritmoPruebas : ContenedorPruebasExp
    {
        //Variables de los resultados
        static int Iteraciones = 0;
        static int Aciertos = 0;
        static double TotalKcal = 0;
        static double TotalPRO = 0;
        static double TotalLIP = 0;
        static double TotalCHO = 0;
        //Multiplicadores de los gramos
        static int PRO = 4;
        static int LIP = 9;
        static int CHO = 4;

        //Variables
        static int RangoKcal = 0;

        //Propiedades
        public static int SetRangoKcal
        {
            get
            {
                return RangoKcal;
            }

            set
            {
                RangoKcal = value;
            }
        }
        public static int SetCalculos
        {
            get
            {
                return Cálculos;
            }

            set
            {
                Cálculos = value;
            }
        }
        public static int SetMinimoKcal
        {
            get
            {
                return MínimoKcal;
            }

            set
            {
                MínimoKcal = value;
            }
        }
        public static int SetMaximoKcal
        {
            get
            {
                return MáximoKcal;
            }

            set
            {
                MáximoKcal = value;
            }
        }
        public static int SetPorcentajePRO
        {
            get
            {
                return PROPorc;
            }

            set
            {
                PROPorc = value;
            }
        }
        public static int SetPorcentajeLIP
        {
            get
            {
                return LIPPorc;
            }

            set
            {
                LIPPorc = value;
            }
        }
        public static int SetPorcentajeCHO
        {
            get
            {
                return CHOPorc;
            }

            set
            {
                CHOPorc = value;
            }
        }

        //Algoritmo que ejecuta todos los métodos
        public static void AlgoritmoEquivalencias()
        {
            CreateArrays();
            Instanciacion();
            EstadísticasGenerales();
            Ciclos();
            Console.WriteLine("Iteraciones = " + Iteraciones);
            Console.WriteLine("Combinaciones correctas = " + Aciertos);
        }

        //Solicita todos los valores y realiza todas las instancias pertinentes
        static void Instanciacion()
        {
            Kcal = (Cálculos * 100) + MínimoKcal; //TOTAL DE CALORÍAS DE LA ITERACIÓN
            Kcal_min = Kcal - RangoKcal;
            Kcal_max = Kcal + RangoKcal;
            IndiceKcal = Kcal / 100;    // VALOR DEL 1% DEL TOTAL DE CALORÍAS

            //KCAL = PORCENTAJE * INDICE
            PROKcal = PROPorc * IndiceKcal;
            LIPKcal = LIPPorc * IndiceKcal;
            CHOKcal = CHOPorc * IndiceKcal;
            //GRAMOS = KCAL / CHO,LIP, ó PRO
            PROGr = PROKcal / PRO;
            LIPGr = LIPKcal / LIP;
            CHOGr = CHOKcal / CHO;

            IndicePROGr = PROGr / 100;
            IndiceLIPGr = LIPGr / 100;
            IndiceCHOGr = CHOGr / 100;

            //MÁRGENES DE ERROR
            PROGr_min = PROGr - (IndicePROGr * 5);
            PROGr_max = PROGr + (IndicePROGr * 5);

            LIPGr_min = LIPGr - (IndiceLIPGr * 5);
            LIPGr_max = LIPGr + (IndiceLIPGr * 5);

            CHOGr_min = CHOGr - (IndiceCHOGr * 5);
            CHOGr_max = CHOGr + (IndiceCHOGr * 5);
        }

        //Ciclos del Cálculo
        static void Ciclos()
        {
            for (int a = 1; a < MaxPorciones[0]; a++)//GRUPO 1
            {
                Porciones[0] = a;
                for (int b = 1; b < MaxPorciones[1]; b++)//GRUPO 2
                {
                    Porciones[1] = b;
                    for (int c = 1; c < MaxPorciones[2]; c++)//GRUPO 3
                    {
                        Porciones[2] = c;
                        for (int d = 1; d < MaxPorciones[6]; d++)//GRUPO 7
                        {
                            Porciones[6] = d;
                            for (int e = 1; e < MaxPorciones[7]; e++)//GRUPO 8
                            {
                                Porciones[7] = e;
                                for (int f = 1; f < MaxPorciones[13]; f++)//GRUPO 14
                                {
                                    Porciones[13] = f;
                                    SubCiclo1();
                                }
                            }
                        }
                    }
                }
            }
        }

        static void SubCiclo1()
        {
            for (int g = 0; g < MaxPorciones[3]; g++)//Grupo Secundario 4
            {
                if (Restricciones[3] == false)
                {
                    Porciones[3] = g;
                    SubCiclo2();
                }
                else
                {
                    SubCiclo2();
                    break;
                }
            }
        }
        static void SubCiclo2()
        {
            for (int h = 0; h < MaxPorciones[4]; h++) //Grupo Secundario 5
            {
                if (Restricciones[4] == false)
                {
                    Porciones[4] = h;
                    SubCiclo3();
                }
                else
                {
                    SubCiclo3();
                    break;
                }
            }
        }
        static void SubCiclo3()
        {
            for (int g = 0; g < MaxPorciones[5]; g++) //Grupo Secundario 6
            {
                if (Restricciones[5] == false)
                {
                    Porciones[5] = g;
                    EvaluaciónCiclo();
                }
                else
                {
                    EvaluaciónCiclo();
                    break;
                }
            }
        }

        // MÉTODOS DE CÁLCULO
        //Calcula los totales actuales

        static void EvaluaciónCiclo()
        {
            Iteraciones++;
            CombinacionPorciones();
            if (CondicionalesQuiebre() == false)
            {
                if (CondicionalesAprobacion() == true)
                {
                    //PrintReport();
                    Aciertos++;
                }
            }
            VaciadoContenedores();
        }
        public static void Totales()
        {
            TotalPRO = 0;
            TotalLIP = 0;
            TotalCHO = 0;
            TotalKcal = 0;

            for (int t = 0; t < Porciones.Length - 1; t++)
            {
                if (Restricciones[t] == false)
                {
                    TotalPRO += GroupProt[t];
                    TotalLIP += GroupLip[t];
                    TotalCHO += GroupCho[t];
                    TotalKcal += GroupKcal[t];
                }
            }
        }
        static void CombinacionPorciones()
        {
            for (int k = 0; k < Porciones.Length - 1; k++)
            {
                if(Restricciones[k] == false)
                {
                    for (int i = 0; i < Porciones[k]; i++)
                    {
                        MetePorcion(k);
                    }
                }
            }
            Totales();
        }
        static void VaciadoContenedores()
        {
            for (int i = 0; i <= Porciones.Length - 1; i++)
            {
                GroupKcal[i] = 0;
                GroupProt[i] = 0;
                GroupLip[i] = 0;
                GroupCho[i] = 0;
            }
        }
        static void MetePorcion(int Iterer)
        {
            GroupKcal[Iterer] += Energy[Iterer];
            GroupProt[Iterer] += Prot[Iterer];
            GroupLip[Iterer] += Lip[Iterer];
            GroupCho[Iterer] += Cho[Iterer];
        }
        static bool CondicionalesQuiebre()
        {
            bool temp = false;
            Totales();
            if (TotalKcal >= Kcal_max)
            {
                temp = true;
            }
            else if (TotalPRO >= PROGr_max)
            {
                temp = true;
            }
            else if (TotalLIP >= LIPGr_max)
            {
                temp = true;
            }
            else if (TotalCHO >= CHOGr_max)
            {
                temp = true;
            }
            else
            {
                temp = false;
            }
            return temp;
        }
        static bool CondicionalesAprobacion()
        {
            Totales();
            bool temp = false;
            bool A = false;
            bool B = false;

            A = TotalKcal >= Kcal_min;
            B = TotalKcal <= Kcal_max;

            if (A & B) //ANILLO 1
            {
                temp = true;
                A = TotalPRO >= PROGr_min;
                B = TotalPRO <= PROGr_max;
                if (A & B) //ANILLO 2
                {
                    temp = true;
                    A = TotalLIP >= LIPGr_min;
                    B = TotalLIP <= LIPGr_max;
                    if (A & B) //ANILLO 3
                    {
                        temp = true;
                        A = TotalCHO >= CHOGr_min;
                        B = TotalCHO <= CHOGr_max;
                        if (A & B) //ANILLO 4
                        {
                            temp = true;
                        }
                        else
                        {
                            temp = false;
                        }
                    }
                    else
                    {
                        temp = false;
                    }
                }
                else
                {
                    temp = false;
                }
            }
            else
            {
                temp = false;
            }

            return temp;
        }

        //Métodos de impresión
        static void EstadísticasGenerales()
        {
            Console.WriteLine("Mínimo Kcal = " + MínimoKcal);
            Console.WriteLine("Máximo Kcal = " + MáximoKcal);
            Console.WriteLine("CHO % = " + CHOPorc);
            Console.WriteLine("LIP % = " + LIPPorc);
            Console.WriteLine("PRO % = " + PROPorc);
            Console.WriteLine("Kcal min = " + Kcal_min);
            Console.WriteLine("Kcal     = " + Kcal);
            Console.WriteLine("Kcal max = " + Kcal_max);
            Console.WriteLine("PRO min  = " + PROGr_min);
            Console.WriteLine("PRO      = " + PROGr);
            Console.WriteLine("PRO max  = " + PROGr_max);
            Console.WriteLine("LIP min  = " + LIPGr_min);
            Console.WriteLine("LIP      = " + LIPGr);
            Console.WriteLine("LIP max  = " + LIPGr_max);
            Console.WriteLine("CHO min  = " + CHOGr_min);
            Console.WriteLine("CHO      = " + CHOGr);
            Console.WriteLine("CHO max  = " + CHOGr_max);
        }
        static void PrintCombinacion()
        {
            for (int k = 0; k < Porciones.Length - 1; k++)
            {
                if (Restricciones[k] == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write("{0} ", Porciones[k]);
            }
            Console.WriteLine();
        }
        public static void PrintReport()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("!!!!UNA COMBINACIÓN CORRECTA!!!!");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Iteracion #: {0}", Iteraciones);
            PrintCombinacion();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Total Kcal = " + TotalKcal);
            Console.Write(" / Total PRO = " + TotalPRO);
            Console.Write(" / Total LIP = " + TotalLIP);
            Console.WriteLine(" / Total CHO = " + TotalCHO);

            for (int k = 0; k <= Groups.Length - 1; k++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(Groups[k]);
                Console.Write(" / Porciones: " + Porciones[k]);
                Console.Write(" / Kcal: " + (Energy[k] * Porciones[k]));
                Console.Write(" / Gr de PRO: " + (GroupProt[k]));
                Console.Write(" / Gr de LIP: " + (GroupLip[k]));
                Console.WriteLine(" / Gr de CHO: " + (GroupCho[k]));
            }
        }
        public static void PrintResults()
        {
            Totales();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Iteracion #: {0}", Iteraciones);
            PrintCombinacion();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Total Kcal = " + TotalKcal);
            Console.Write(" / Total PRO = " + TotalPRO);
            Console.Write(" / Total LIP = " + TotalLIP);
            Console.WriteLine(" / Total CHO = " + TotalCHO);

            for (int k = 0; k <= Groups.Length - 1; k++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(Groups[k]);
                Console.Write(" / Porciones: " + Porciones[k]);
                Console.Write(" / Kcal: " + (Energy[k] * Porciones[k]));
                Console.Write(" / Gr de PRO: " + (GroupProt[k]));
                Console.Write(" / Gr de LIP: " + (GroupLip[k]));
                Console.WriteLine(" / Gr de CHO: " + (GroupCho[k]));
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintTotales()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Total Kcal = " + TotalKcal);
            Console.Write(" / Total PRO = " + TotalPRO);
            Console.Write(" / Total LIP = " + TotalLIP);
            Console.WriteLine(" / Total CHO = " + TotalCHO);
        }
    }
}