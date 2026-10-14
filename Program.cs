using System.ComponentModel.Design;

namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {

        // Consignes
        int running = 0;

        while (running == 0)
        {
            // Demandez à l'utilisateur un nombre
            Console.WriteLine("- Donne-moi un nombre");
            int number = Convert.ToInt32(Console.ReadLine());
            // Dites à l'utilisateur si le nombre fourni est pair ou impair
            if ((number % 2) == 1)
            {
                Console.WriteLine("- C'est impair!");
            }
            else
            {
                Console.WriteLine("- C'est pair!");
            }
            // Demandez à l'utilisateur s'il veut proposer un autre nombre
            Console.WriteLine("- Veut-tu donner un autre nombre? (taper [y] si oui, tout autre réponse ferme le programme)");
            string answer = Console.ReadLine();
            //  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
            if (!(answer == "y"))
            {
                running = 1;
            }
        }
    }
}
