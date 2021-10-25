using System;

namespace ENVOIE_VECT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel VECT souhaitez vous générer ? : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] VECT = GenerateurAVect(n);
            Affichage(VECT);
        }

        /// <summary>
        /// Reçoit un int n qui correspond a la taille du vect (exemple n = 2 pour VECT de R2)
        /// On créer une matrice avec chaque ligne une composante du VECT
        /// chaque ligne contient n cases avec n-1 0 et un seul 1 qui n'est jamais a la même place dans chaque composante.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>

        public static int[,] GenerateurAVect(int n)
        {
            if (n <= 0) return null;
            int[,] VECT = new int[n,n];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == index)
                    {
                        VECT[i, j] = 1;

                    }
                    else
                    {
                        VECT[i, j] = 0;
                    }
                }
                index++;
                
            }
            return VECT;
        }

        public static void Affichage(int[,]mat)
        {
            if (mat == null) Console.Write("Matrice nul / VECT n'existe pas");

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write("{");
                for(int j = 0; j < mat.GetLength(1);j++)
                {
                    if (j == mat.GetLength(1) - 1) Console.Write(mat[i, j]);
                    else Console.Write(mat[i, j] + ",");
                }
                Console.Write("} , ");
            }
        }
    }
}
