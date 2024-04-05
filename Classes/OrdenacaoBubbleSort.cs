using EstruturaDeDados.Modelos;

namespace EstruturaDeDados.Classes
{
    public static class OrdenacaoBubbleSort
    {
        public static int[] ExecutarIntASC(int[] iArray)
        {
            int[] iArrayRetorno = new int[iArray.Length];
            iArrayRetorno = iArray;
            bool percorer = false;
            do
            {
                percorer = false;
                for (int i = 0; i < iArrayRetorno.Length - 1; i++)
                {
                    if (iArrayRetorno[i] > iArrayRetorno[i + 1])
                    {
                        int obj = iArrayRetorno[i];
                        iArrayRetorno[i] = iArrayRetorno[i + 1];
                        iArrayRetorno[i + 1] = obj;
                        percorer = true;
                    }
                }

            } while (percorer);
            return iArrayRetorno;
        }

        public static int[] ExecutarIntDESC(int[] iArray)
        {
            int[] iArrayRetorno = new int[iArray.Length];
            iArrayRetorno = iArray;
            bool percorer = false;
            do
            {
                percorer = false;
                for (int i = 0; i < iArrayRetorno.Length -1; i++)
                {
                    if (iArrayRetorno[i] < iArrayRetorno[i + 1])
                    {
                        int obj = iArrayRetorno[i];
                        iArrayRetorno[i] = iArrayRetorno[i + 1];
                        iArrayRetorno[i + 1] = obj;
                        percorer = true;
                    }
                }

            } while (percorer);
            return iArrayRetorno;
        }

        public static double[] ExecutarDoubleASC(double[] array)
        {
            bool percorer = false;
            do
            {
                percorer = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        double obj = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = obj;
                        percorer = true;
                    }
                }

            } while (percorer);
            return array;
        }

        public static double[] ExecutarDoubleDESC(double[] array)
        {
            bool percorer = false;
            do
            {
                percorer = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        double obj = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = obj;
                        percorer = true;
                    }
                }

            } while (percorer);
            return array;
        }

        public static float[] ExecutarFloatASC(float[] array)
        {
            bool percorer = false;
            do
            {
                percorer = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        float obj = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = obj;
                        percorer = true;
                    }
                }

            } while (percorer);
            return array;
        }
        
        public static float[] ExecutarFloatDESC(float[] array)
        {
            bool percorer = false;
            do
            {
                percorer = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        float obj = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = obj;
                        percorer = true;
                    }
                }

            } while (percorer);
            return array;
        }

        public static decimal[] ExecutarDecimalASC(decimal[] array)
        {
            bool percorer = false;
            do
            {
                percorer = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        decimal obj = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = obj;
                        percorer = true;
                    }
                }

            } while (percorer);
            return array;
        }

        public static decimal[] ExecutarDecimalDESC(decimal[] array)
        {
            bool percorer = false;
            do
            {
                percorer = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        decimal obj = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = obj;
                        percorer = true;
                    }
                }

            } while (percorer);
            return array;
        }

        public static Pessoa[] ExecutarPessoaIDASC(Pessoa[] array)
        {
            bool percorer = false;
            do
            {
                percorer = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].PESSOA_ID > array[i].PESSOA_ID)
                    {
                        Pessoa obj = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = obj;
                        percorer = true;
                    }
                }
            } while (percorer);
            return array;
        }

        public static Pessoa[] ExecutarPessoaIDDESC(Pessoa[] array)
        {
            bool percorer = false;
            do
            {
                percorer = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].PESSOA_ID < array[i].PESSOA_ID)
                    {
                        Pessoa obj = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = obj;
                        percorer = true;
                    }
                }
            } while (percorer);
            return array;
        }
    }
}