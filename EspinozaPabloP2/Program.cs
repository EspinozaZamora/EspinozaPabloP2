using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main()
        {
            int A;
            A = 100;
            Descendente b = new Descendente(A);
        }
    }

    class Descendente
    {
        int x;
        int[] Vec;
        int Sum = 0;
        int Prom;
        int Max;
        int Min;
        int Dece;
        int Acum = 0;
        public Descendente(int A)
        {
            x = A;
            Vec = new int[x];

            var B = Environment.TickCount;
            var random = new Random(B);
            for (int i = 0; i < x; i++)
            {
                var Val = random.Next(5, 50);

                Vec[i] = Val;
                Dece = Vec[i] % 10;
                if (Dece == 0)
                    Acum = Acum + 1;

            }
            Ordenamiento(Vec, 0, x - 1);
            Imrpimir();
        }

        private void Ordenamiento(int[] Vectores, int Prim, int Ultm)
        {
            int y, z, Cent;
            double pivote;
            Cent = (Prim + Ultm) / 2;
            pivote = Vectores[Cent];
            y = Prim;
            z = Ultm;
            do
            {
                while (Vectores[y] < pivote) y++;
                while (Vectores[z] > pivote) z--;
                if (y <= z)
                {
                    int temp;
                    temp = Vectores[y];
                    Vectores[y] = Vectores[z];
                    Vectores[z] = temp;
                    y++;
                    z--;
                }
            } while (y <= z);

            if (Prim < z)
            {
                Ordenamiento(Vectores, Prim, z);
            }
            if (y < Ultm)
            {
                Ordenamiento(Vectores, y, Ultm);
            }
        }

        private void Imrpimir()
        {
            Console.WriteLine("Ordenamiento del vector Ascendentemente");

            for (int i = x - 1; i > 0; i--)
            {
                Console.Write("{0} ", Vec[i]);
                Sum = Sum + Vec[i];
            }
            Prom = Sum / x;
            Min = Vec[x - 9];
            Max = Vec[x - 1];

            Console.Write("*** \n Sumatoria de Vector: {0} ***", Sum);
            Console.Write("*** \n Promedio es: {0} ***", Prom);
            Console.Write("*** \nEl Valor Maximo es: {0} ***", Max);
            Console.Write("*** \nEl Valor Minimo es: {0} ***", Min);
            Console.Write("*** \nLa Las decenas: {0} ***", Acum);
            Console.ReadLine();
        }


    }
}