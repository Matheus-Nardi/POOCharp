using System.ComponentModel;

namespace PraticandoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex05();
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
            int n ;
            
            for(int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite o {i+1} número");
                n = int.Parse(Console.ReadLine());
                num.Add(n); 
            }
            int numMaior = num[0];
            int numMenor = num[0];
               
            foreach(var i in num)
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
            var num = new List<int>() ;
            var numPar = new List<int>();
            var numImpar = new List<int>();

            int imputNumero ;

            Console.WriteLine("Lista de quantos números ? ");
            var quantidade = int.Parse(Console.ReadLine());
            for(int j = 0; j<quantidade; j++)
            {
                Console.WriteLine($"Digite o {j+1} numero : ");
                imputNumero = int.Parse(Console.ReadLine());
                num.Add(imputNumero);

            }
            foreach (int i in num)
            {
                if(i%2 == 0)
                {
                    numPar.Add(i);
                }
                else
                {
                    numImpar.Add(i);
                }
            }

            Console.WriteLine("Percorrendo valores pares");

            foreach(int i in numPar)
                Console.WriteLine(i);

            Console.WriteLine("------------------------");
            Console.WriteLine("Percorrendo valores impares");
            foreach (int i in numImpar)
                Console.WriteLine(i);


        }
        
        public static void Ex05()
        {
            var cores = new List<string>() {"Azul" , "Vermelho" , "Laranja" , "Preto" , "Branco" , "Roxo"} ;
            Console.WriteLine("Qual a sua cor favorita :)");
            string corFavorita = Console.ReadLine();
            cores.Add(corFavorita);
            if(cores.Contains(corFavorita))
            {
                Console.WriteLine("ESSA COR JA EXISTE NA LISTA ");
            }
            Console.WriteLine("TODAS AS CORES");
            foreach(var cor in cores)
                Console.WriteLine(cor);
            Console.WriteLine("--------------------");
            Console.WriteLine("REMOVENDO INDICE 3 ");
            cores.RemoveAt(3);
            foreach(var cor in cores)
                Console.WriteLine(cor);

        }
    }
}