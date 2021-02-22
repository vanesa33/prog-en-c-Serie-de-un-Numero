using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SERIE_DE_UN_NÚMERO
{
    class Program
    {
        static void Main(string[] args)
        {
            byte NUM, K, F;
            long FAC;
            double RESUL = 0;
            string linea;
            Console.Write("DIGITE UN NÚMERO: "); linea = Console.ReadLine();
            NUM = byte.Parse(linea);
            for (K = 1; K <= NUM; K++)
            {
                FAC = 1;
                for (F = 1; F <= K; F++)
                {
                    FAC = FAC * F;
                }
                RESUL = RESUL + (K / FAC);
            }
            Console.WriteLine("RESULTADO DE LA SERIE ES: " + RESUL);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}