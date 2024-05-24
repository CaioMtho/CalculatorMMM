using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http.Headers;

namespace Calculadora
{
    class Program
    {
        private static void Escolha(int resUser)
        { // Método que expõe resultados e chama funções de calculo
            Calculo calculo = new Calculo();

            List<float> lista = new List<float>();
            int resLen;

            Console.WriteLine("Quantos numeros existem na lista?\t");
            resLen = int.Parse(Console.ReadLine());

            // lança uma exceção caso a lista seja menor que 2 itens
            if (resLen < 2)
            {
                Console.WriteLine("Nao ha como calcular com menos de 2 itens por lista!");
                throw new FormatException("");
            }
            // armazena os inputs do usuario em uma lista
            for (int i = 0; i < resLen; i++)
            {
                Console.Write("Digite um numero: ");
                lista.Add(float.Parse(Console.ReadLine()));
            }
            // switch om os métodos conforme determinado pelo usuário em Main
            switch (resUser)
            {
                case 1:
                    Console.WriteLine($"MEDIA = {calculo.Media(lista):0.00}");
                    break;
                case 2:
                    Console.WriteLine($"MODA = {calculo.Moda(lista)}");
                    break;
                case 3:
                    Console.WriteLine($"MEDIANA = {calculo.Mediana(lista)}");
                    break;

            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tCALCULADORA MMM\t\t");
            // loop  do menu principal
            while (true)
            {
                Console.WriteLine("Digite 0 para sair, 1 para media, 2 para moda e 3 para mediana...");
                try
                {
                    int resUser = int.Parse(Console.ReadLine());
                    if (resUser == 0)
                    {
                        Console.WriteLine("Aperte Enter... Volte sempre!");
                        Console.ReadLine();
                        break;
                    }
                    if (resUser != 1 && resUser != 2 && resUser != 3)
                    {
                        Console.WriteLine("Digite um numero valido!");
                        continue;
                    }

                    Escolha(resUser);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um numero valido!");
                }

            }
        }
    }
}