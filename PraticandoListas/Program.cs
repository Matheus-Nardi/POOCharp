using System;
using System.ComponentModel;

namespace PraticandoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex12();
            Console.ReadLine();
        }

        public static void Ex01()
        {
            var nums = new List<int>();
            nums.Add(1);
            nums.Add(4);
            nums.Add(6);
            nums.Add(10);
            nums.Add(18);

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
        public static void Ex02()
        {
            var nums = new List<int>();
            nums.Add(8);
            nums.Add(18);
            nums.Add(58);
            int soma = 0;
            foreach (int i in nums)
            {
                soma = soma + i;
            }
            Console.WriteLine(soma);
        }

        public static void Ex03()
        {
            var num = new List<int>();
            Console.WriteLine("Quantos números ?");
            var quantidade = int.Parse(Console.ReadLine());
            int n;

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o {i + 1} número");
                n = int.Parse(Console.ReadLine());
                num.Add(n);
            }
            int numMaior = num[0];
            int numMenor = num[0];

            foreach (var i in num)
            {
                if (i < numMenor)
                    numMenor = i;
                if (i > numMaior)
                    numMaior = i;
            }
            Console.WriteLine($"MAIOR : {numMaior} MENOR : {numMenor}");

        }

        public static void Ex04()
        {
            var num = new List<int>();
            var numPar = new List<int>();
            var numImpar = new List<int>();

            int imputNumero;

            Console.WriteLine("Lista de quantos números ? ");
            var quantidade = int.Parse(Console.ReadLine());
            for (int j = 0; j < quantidade; j++)
            {
                Console.WriteLine($"Digite o {j + 1} numero : ");
                imputNumero = int.Parse(Console.ReadLine());
                num.Add(imputNumero);

            }
            foreach (int i in num)
            {
                if (i % 2 == 0)
                {
                    numPar.Add(i);
                }
                else
                {
                    numImpar.Add(i);
                }
            }

            Console.WriteLine("Percorrendo valores pares");

            foreach (int i in numPar)
                Console.WriteLine(i);

            Console.WriteLine("------------------------");
            Console.WriteLine("Percorrendo valores impares");
            foreach (int i in numImpar)
                Console.WriteLine(i);


        }

        public static void Ex05()
        {
            var cores = new List<string>() { "Azul", "Vermelho", "Laranja", "Preto", "Branco", "Roxo" };
            Console.WriteLine("Qual a sua cor favorita :)");
            string corFavorita = Console.ReadLine();
            cores.Add(corFavorita);
            if (cores.Contains(corFavorita))
            {
                Console.WriteLine("ESSA COR JA EXISTE NA LISTA ");
            }
            Console.WriteLine("TODAS AS CORES");
            foreach (var cor in cores)
                Console.WriteLine(cor);
            Console.WriteLine("--------------------");
            Console.WriteLine("REMOVENDO INDICE 3 ");
            cores.RemoveAt(3);
            foreach (var cor in cores)
                Console.WriteLine(cor);

        }

        public static void Ex06()
        {
            var num = new List<int>() { 3, 8, 9, 0 };
            Console.WriteLine("Lista Ordenada");
            num.Sort();
            foreach (var i in num) Console.WriteLine(i);
        }

        public static void Ex07()
        {
            int countNome = 0;
            var nomes = new List<string>() { "Matheus", "Pedro", "Paulo", "Vinicius", "Pedro", "Pedro" };
            foreach (var i in nomes)
            {
                if (i.Contains("Pedro"))
                {
                    countNome++;
                }

            }
            Console.WriteLine($"O nome Pedro aparece na lista {countNome} vezes");
        }

        public static void Ex08()
        {
            var numeros1 = new List<int>() { 0, 8, 2, 10, };
            var numeros2 = new List<int>() { 1, 8, 12, 16 };
            var uniao = new List<int>();
            uniao.AddRange(numeros1);
            uniao.AddRange(numeros2);
            uniao.Sort();

            foreach (var item in uniao)
            {
                Console.WriteLine(item);
            }
        }

        public static void Ex09()
        {
            var srt = new List<String>() { "Manteiga", "Pao", "Macarraõ ", "Feijão", "Carne", "Frango" };
            srt.Sort();
            srt.Reverse();
            foreach (var item in srt)
            {
                Console.WriteLine(item);
            }
        }

        public static void Ex10()
        {
            var numeros = new List<int>() { 0, 8, 3, 8, 10, 14, 16 };
            numeros = numeros.Distinct().ToList();
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }


        }

        public static void Ex11()
        {
            var nomes = new List<string>();
            nomes.Add("Pedro");
            nomes.Add("Robson");
            nomes.Add("Matheus");
            nomes.Add("Pietra");
            nomes.Add("Giraldo");
            while (true)
            {
                Console.WriteLine("Que nome deseja buscar? | Digite 0 para sair ");
                var userInput = Console.ReadLine();

                if (userInput == "0")
                {
                    Console.WriteLine("Saindo do programa...");
                    System.Environment.Exit(0);
                }
                

                var nomeNaLista = nomes.Contains(userInput);

                if (!nomeNaLista)
                {
                    Console.WriteLine("Nome não encontrado");
                    Console.WriteLine($"Deseja adicionar {userInput} na lista? (y|n)");
                    char op = char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                    Console.Clear();

                    if (op == 'y')
                    {
                        nomes.Add(userInput);
                        Console.WriteLine("Nome adicionado");
                        Console.WriteLine("Lista Atual ");
                        foreach (var item in nomes)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bye");
                    }
                }
                else
                {
                    Console.WriteLine($"O nome {userInput} está na lista");
                }
            }
        }

        public static void Ex12()
        {
            
            var lista = new List<object>() { 'a' , 12  , "pedro" , -10  , 100 , 'c'};

            foreach (var item in lista)
            {
                Console.WriteLine(item);

            }

            var onlyint = lista.OfType<int>().ToList();

            foreach (var item in onlyint)
            {
                Console.WriteLine(item);
            }
        }
    }
}   











