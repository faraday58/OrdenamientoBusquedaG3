using System;
using System.Diagnostics;
namespace OrdenamientoBusquedaG3
{
    class Program
    {
        static void Main()
        {
            int[] A = { 25, 5 ,30, 10, 50,45 };
            Console.WriteLine("Dame el valor a buscar:  ");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine(" El valor se encontro en: {0} ", BusquedaDirecta(A,X ));
            /*
            Random aleatorio = new Random();
            int[] A = new int[20];



            for(int i=0; i< A.Length; i++  )
            {
                A[i] =  (int)(aleatorio.NextDouble()*1000);
            }*/




            /*
                        Stopwatch sw = new Stopwatch();
                        sw.Start();         
                        //Burbuja será medida su velocidad de ejecución
                        Burbuja(A);
                        sw.Stop();

                        Console.WriteLine("Tiempo de ejecución de Burbuja es: {0} [ms]", sw.ElapsedMilliseconds);
            */
            /*
            foreach(int v in A )
            {
                Console.Write(" {0} ", v);
            }*/

            Console.WriteLine();
            Console.ReadLine();
        }

        static void Burbuja(int [] A  )
        {
            int N = A.Length;
            int Aux;

            for(int i=0; i < N; i++ )
            {
                for(int j=0; j < N-1; j++   )
                {
                    if( A[j] > A[j+1]    )
                    {
                        Aux = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = Aux;
                    }

                }

            }
        }

        static int BusquedaDirecta(int [] A, int X )
        {
            int N = A.Length;
            for(int i=0; i < N; i++ )
            {
                if(X == A[i] )
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
