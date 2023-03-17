namespace exDiamanteLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabeto = alf.ToCharArray();

            Console.WriteLine("Digite ate q letra voce ira querer formar o diamante:");
            char x = char.Parse(Console.ReadLine());

            int n = 0;            
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (alfabeto[i] == x)
                {
                    n = i;
                }
            }

            int nBrancos = n;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < nBrancos; j++)
                {
                    Console.Write(" ");
                }
                nBrancos--;
                for (int j = 0; j <= i * 2; j++)
                {
                    if(j == 0 || j == i * 2)
                    {
                        Console.Write(alfabeto[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                  
                Console.WriteLine();
            }
            nBrancos = 1;
            for (int i = n-1; i >= 0; i--)
            {
                for(int j = nBrancos; j > 0; j--)
                {
                    Console.Write(" ");
                }
                nBrancos++; ;
                for (int j = i * 2; j >= 0; j--)
                {
                    if (j == 0 || j == i * 2)
                    {
                        Console.Write(alfabeto[i]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}