
// inteiro num

using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

//int num = 0;  // daclaraçaõ de variável tipo inteiro
//string texto = "x";  // variável do tipo texto
//double num1 = 0; //variável com casas após a vargula
//DateTime data = DateTime.Now; //var~´avel para data

//Console.WriteLine("Digite o seu nome:");
//texto=Console.ReadLine();

//Console.WriteLine("Seu nome é: " + texto);






//double peso, altura;

//Console.WriteLine("Digite o seu peso:");
////peso = Convert.ToDouble (Console.ReadLine());

//Console.WriteLine("Digite o seu altura:");
//altura = Convert.ToDouble (Console.ReadLine());

//Console.WriteLine ($"Seu IMC é: {peso / (altura * altura) }");







//double C, F;

//Console.WriteLine("Digite a temperatura em Celsius:");
//C = Convert.ToDouble (Console.ReadLine());

//F = (C * 1.8) + 32;

//Console.WriteLine($"A temperatura em Fahrenheit é: {F}°F");








//string nome;
//int idade;
//double altura;

//Console.WriteLine("Digite o seu nome");
//nome = Console.ReadLine();

//Console.WriteLine("Digite o seu idade");
//idade = int.Parse (Console.ReadLine());

//Console.WriteLine("Digite o seu altura");
//altura = Convert.ToDouble (Console.ReadLine());

//Console.WriteLine($"Olá {nome}! Você tem {idade} Anos e tem {altura}m ");







//Console.WriteLine("Digite sua idade:");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine("Você é maior de idade!");
//}
//else
//{
//    Console.WriteLine("Você é menor de idade!");
//}




//Console.WriteLine("1 - Brasil");
//Console.WriteLine("2 - Tailandia");
//Console.WriteLine("3 - Alemanha");
//Console.WriteLine("Escolha um país pelo indice:");
//int opcao = Convert.ToInt32(Console.ReadLine());

//Console.Clear(); //Comando para limpar o terminal.

//switch (opcao)
//{
//    case 1:
//        Console.WriteLine("Você escolheu o Brasil!");
//        break;
//    case 2:
//        Console.WriteLine("Você escolheu a Tailandia!");
//        break;
//    case 3:
//        Console.WriteLine("Você escolheu a Alemanha!");
//        break;
//    default:
//        Console.WriteLine("Opção Invalida!!");
//        break;
//}





Console.WriteLine("Digite o seu nome ");
string nome = Console.ReadLine();

Console.WriteLine("Digite a primeira nota ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a primeira nota ");
double nota2 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2) /2;

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5)
{
    Console.WriteLine("Recuperação");
}else 
{
 Console.WriteLine("Reprovado");
} 

switch (media)
{
    case 1:
        Console.WriteLine();
    
        break;



}





