using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    // 
    class Program
    {
        // Comparer deux chaines de caractères
        public static bool ComparerChaines(string p_chaine1,string p_chaine2)
        {
            if (p_chaine1.Length == p_chaine2.Length)
                return true;
            else return false;
               
        }
        static void Main(string[] args)
        {
            if (ComparerChaines("Hasna", "Didier"))

                Console.WriteLine("Les deux chaines ont la même longueur.");
            else
                Console.WriteLine("Les deux chaines n'ont pas la même longueur.");
            Console.ReadKey();
        }
    }
}
