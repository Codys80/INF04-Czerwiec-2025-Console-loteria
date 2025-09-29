namespace Loteria_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random losowy = new Random();
            int ileZestawow = Convert.ToInt16(Console.ReadLine());
            int[,] zestaw = new int[ileZestawow, 6];
            int[,] wypelnij(int[,] zestaw)
            { 
                for (int i = 0; i < ileZestawow; i++)
                    {
                        for(int j = 0; j < 6; j++)
                        {
                            zestaw[i, j] = losowy.Next(1,49);
                            Console.WriteLine("Numer losowania: "+i+" numer j: "+j+" Wylosowana liczba: "+zestaw[i, j]);
                    }    
                    }
                    return zestaw;
            }
            wypelnij(zestaw);
        }
    }
}
