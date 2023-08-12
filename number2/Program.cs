using System;

namespace My_program{

    class Program{

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Qual seu nome?");

            string userName = Console.ReadLine();

            Console.WriteLine("Ola! "+userName +", prazer em te conhecer!");
            */
/*
            double num1;
            double num2;
            double Soma;

            Console.WriteLine("Insira um numero: ");
            //Quando eu Coloco o Console.ReadLine(); eu estou atribuindo um valor em uma
            //String que precisa ser convertida para ser armazenada em uma variavel de valor int
            num1 =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");

            num2 = Convert.ToDouble(Console.ReadLine());

            Soma = num2 * num1;

            Console.WriteLine("O resultado final da soma é: "+Soma);
*/

/*
        //Programa tirar a média

        double num1;
        double num2;
        double num3;

        double media;

        
        Console.WriteLine("Digite o primero valor para tirar a média: ");

        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor para tirar a média: ");

        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor para tirar a média: ");

        num3 = Convert.ToDouble(Console.ReadLine());
        
        media = (num1+num2+num3)/3;

        Console.WriteLine("O resultado final da média é: "+media);
   */
    
    //maquina de pesquisa !
    string nome;
    int idade;

    Console.WriteLine("olá, bem vindo ao meu programa, por favor, digite seu nome");

    nome = Console.ReadLine();     
   
    Console.WriteLine("\nLegal! Pazer " +nome + ", eu sou a maquina de pesquisas");

    Console.WriteLine("\nDigite sua idade:");
    
    idade = Convert.ToInt32(Console.ReadLine());

    if(idade > 30){

        Console.WriteLine("Ta velho em  kkkkk");
    }else
    {
        Console.WriteLine("Novinho de tudo ainda kkkkkkkkkk");
    }



            Console.ReadKey();
   
        }


    }

}  