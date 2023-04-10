using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Super Calculator!");
            Console.WriteLine("");
            Menu();
        }

        static void Menu(){
            #region Message of options of menu
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("");
            #endregion

            #region User's input
                Console.WriteLine("Digite uma das opções do menu:");
                bool optionInput  = short.TryParse(Console.ReadLine(), out short optionMenu);
                Console.WriteLine("Digite o primeiro número:");
                bool numberOneInput = float.TryParse(Console.ReadLine(), out float numberOne);
                Console.WriteLine("Digite o segundo número:");
                bool numberTwoInput = float.TryParse(Console.ReadLine(), out float numberTwo);
            #endregion

            #region Validating Inputs
                if(!optionInput && (!numberOneInput || !numberTwoInput)){
                    Error("Entrada inválida, digite somente números");
                }
            #endregion

            switch(optionMenu){
                case 0: Exit(); break;
                case 1: Sum(numberOne, numberTwo); break;
                case 2: Subtract(numberOne, numberTwo); break;
                case 3: Multiply(numberOne, numberTwo); break;
                case 4: Divide(numberOne, numberTwo); break;
                default: Error(); break;
            }
        }

        static void Error(string message = "Valor não parametriado, reiniciando aplicação"){
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(1500);
            Console.Clear();
            Menu();
        }

        static void Exit(){
            Console.Clear();
            Console.Write("Obrigado por usar meu programa!!!");
            Thread.Sleep(2000);
            System.Environment.Exit(0);
        }

        static void PrintResult(float result, string operation){
            Console.Clear();
            Console.WriteLine($"O resultado da {operation} é: {result}");
            Thread.Sleep(2500);
            Console.Clear();
            Menu();
        }

        static void Sum(float numberOne, float numberTwo){
            PrintResult((numberOne + numberTwo), "soma");
        }

        static void Subtract(float numberOne, float numberTwo){
            PrintResult((numberOne - numberTwo), "subtração");
        }

        static void Multiply(float numberOne, float numberTwo){
            PrintResult((numberOne * numberTwo), "multiplicação");
        }

        static void Divide(float numberOne, float numberTwo){
            PrintResult((numberOne / numberTwo), "divisão");
        }
    }
}