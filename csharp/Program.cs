using System;
using Enum;
using CSharp;





namespace CSharp
{

    class Program
    {
        private static bool pessoa2;
        private static bool pessoa1;

        public static bool Pessoa1 { get; set; }
        public static bool Pessoa2 { get; set; }
        public static bool Pessoa0 { get;  set; }
        public static bool Pessoa3 { get; set; }

        static void Main(string[] args)
        {
            var pessoa = (Pessoas)0;
            Pessoas Pessoa0 = (Pessoas)0;
            Pessoas pessoa1 = (Pessoas)1;
            Pessoas pessoa2 = (Pessoas)2;
            Pessoas pessoa3 = (Pessoas)3;
            Pessoas pessoa4 = (Pessoas)4;   
            


            Pessoa person = new Pessoa();

            person.Nome = "celio";
            person.Idade = 33;
            person.Estado = "SC";

            var person2 = new Pessoa();

            person2.Nome = "julia";
            person2.Estado = "MG";
            person2.Idade = 23;

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.Dono = "celio";
            animal.Especie = "cachorro";


            Console.WriteLine(Pessoa0);
            Console.WriteLine(pessoa1);
            Console.WriteLine(pessoa2);
            Console.WriteLine(pessoa3);
            Console.WriteLine(pessoa4);
            
            

        }
    }
}
