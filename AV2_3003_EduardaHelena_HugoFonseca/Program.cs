using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV2_3003_EduardaHelena_HugoFonseca
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 9, 6, 5, 2, 7, 3};
            int length = number.Length;
    
            int indice = 0;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (number[i] > number[j])
                    {
                        indice = number[i];

                        number[i] = number[j];

                        number[j] = indice;     
                        
                    }  
                }

                Console.WriteLine(number[i]);
            }

            Console.ReadKey();
        }
    }
}
