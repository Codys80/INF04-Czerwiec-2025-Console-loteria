namespace Loteria_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random losowy = new Random();
            int ileZestawow = Convert.ToInt16(Console.ReadLine());
            int[,] zestaw = new int[ileZestawow, 6];
            int[] wystapienia = new int[50];

            void wyswietl()
            {
                for (int i = 0; i < ileZestawow; i++)
                {
                    Console.Write("\nNumer losowania: " + i + " Wylosowane liczby: ");
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(" " + zestaw[i, j]);
                    }
                }
                        for(int k = 1; k<50; k++)
                        {
                            Console.Write("\nIlośc wystąpień liczby: " + k + " wynosi: " + wystapienia[k]);
                        }
            }
            int[,] wypelnij(int[,] zestaw)
            { 
                for (int i = 0; i < ileZestawow; i++)
                    {
                        for(int j = 0; j < 6; j++)
                        {
                        zestaw[i, j] = losowy.Next(1,49);
                            for (int k = 1; k < 50; k++)
                            {
                                if (zestaw[i, j] == k)
                                {
                                    wystapienia[k]++;
                                }
                            }
                        }    
                    }
                    return zestaw;
            }


            wypelnij(zestaw);
            wyswietl();
        }
    }
}
