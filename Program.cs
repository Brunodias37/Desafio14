using System;
using System.Linq;

namespace Desafio14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] conjunto1 = new int[] { 10, 20, 30, 40, 50, 10 };
            int[] conjunto2 = new int[] { 10, 15, 20, 25, 30 };

            //Pesquisar e utilizar os métodos Except, Intersect e Union

            void Exception()
            {
                var except = conjunto1.Except(conjunto2);
                foreach (var item in except)
                {
                    Console.Write(item + ", ");
                }

                Console.WriteLine("Pressione ENTER para voltar ao menu");
                Console.ReadKey();

            }

            void Intersect()
            {
                var intersection = conjunto1.Intersect(conjunto2);
                foreach (var item in intersection)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("Pressione ENTER para voltar ao menu");
                Console.ReadKey();
            }

            void Union()
            {
                var union = conjunto1.Union(conjunto2);
                foreach (var item in union)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("Pressione ENTER para voltar ao menu");
                Console.ReadKey();
            }


            bool menu = false;
            do
            {
                Console.WriteLine("Metodos do LINQ: ");
                Console.WriteLine("Conjuntos:");
                Console.Write("Conjunto 1 : ");
                for (int i = 0; i < conjunto1.Length; i++)
                {

                    Console.Write($"{conjunto1[i]}, ");
                }
                Console.WriteLine();
                Console.Write("Conjunto 2 : ");
                for (int i = 0; i < conjunto2.Length; i++)
                {

                    Console.Write($"{conjunto2[i]}, ");
                }
                Console.WriteLine();


                Console.WriteLine("[1]- Método Except");
                Console.WriteLine("[2]- Método Intersect");
                Console.WriteLine("[3]- Método Union");
                Console.WriteLine("[4]- Exit");
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Exception();
                        break;
                    case 2:
                        Intersect();
                        break;
                    case 3:
                        Union();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();

            } while (menu == false);

        }
    }
}
