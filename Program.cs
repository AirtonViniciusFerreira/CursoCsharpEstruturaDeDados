using System;
using EstruturaDeDados.Classes;

namespace EstruturaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[500];
            int[] iArrayAsc = new int[500];
            int[] iArrayDesc = new int[500];
            bool bIntOk = true;
            for (int i = 0; i < 500; i++)
            {
                int iGerado = new Random().Next();
                iArray[i] = iGerado;
            }
            iArrayAsc = OrdenacaoBubbleSort.ExecutarIntASC(iArray);
            iArrayDesc = OrdenacaoBubbleSort.ExecutarIntDESC(iArray);
            for (int i = 0; i < iArray.Length; i++)
            {
                if (iArrayAsc[i] != iArrayDesc[i])
                {
                    bIntOk = false;
                    break;
                }
            }
            Console.WriteLine(bIntOk);
        }
    }
}
