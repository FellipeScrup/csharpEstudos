using System;

namespace My_program{

    class Program{

        static void Main(string[] args)
        {
            //Change appearance consol

            Console.Title = "Program";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WindowHeight = 40;

            //Get conversation

            Console.WriteLine("Olá meu caro, você é um cavaleiro lendario,\nqual seu nome?");

            Console.ReadLine();

            Console.WriteLine("\nBelo nome, você chega em uma montanha com uma taberna,\ndeseja entra nela? ");

            Console.ReadLine();

            Console.WriteLine("\nVocê adentra a taberna e se senta enfrente ao balcao,\no balconista pergunta o que você deseja beber\no que você quer beber?");

            Console.ReadLine();

            Console.WriteLine("\nBela escolha! No que o balconista se vira para fazer seu drink voce ouve um estouro\ndeseja sair para ver o que eh?");

            Console.ReadLine();

            Console.WriteLine("\nVocê sai da taberna e se depara um dragao gigante.\no que você ira fazer?");

            Console.ReadLine();

            Console.WriteLine("\nVocê decide lutar, porem o dragao era muito forte e te matou queimado\n\n\nFIM!");

            Console.ReadKey();
        }


    }

}  