using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Daniel "); //O método "Console.WriteLine" quebra a linha no console, ou seja, pula uma linha


        // Console.WriteLine("Almeida"); //O método "Console.Write" não quebra a linha no console

        // int codigo = Console.Read();

        // Console.WriteLine(codigo);

        Console.WriteLine("Por favor, insira os dados solicitados: \n");

        Console.WriteLine("Qual o seu nome? \n");
        string texto = Console.ReadLine();

        Console.WriteLine("Qual a sua idade? \n");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual a sua altura (Não é necessário colocar o 'm' e utilize o formato X,XX)?  \n");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a data de hoje? \n");
        DateTime data = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Dados inseridos");

        Console.WriteLine("======================");

        Console.WriteLine("- Nome: " + texto);
        Console.WriteLine("- Idade: " + idade);
        Console.WriteLine("- Altura: " + altura);

        Console.WriteLine("Data: " + data.ToString("dd/MM/yyyy"));

        Console.WriteLine("-------------------");

        Console.WriteLine("Obrigado. Os seus dados foram inseridos no banco de dados!");

        



        Console.ReadKey();
    }

}

