using System;
namespace EstudosNCode { class Program { static void Main(string[] args) 
        { Console.WriteLine("--------------------------------------------------"); 
            Console.WriteLine("Sequência Maneira!");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Entre com sua frase:"); string phrase = Console.ReadLine(); 
            string[] words = phrase.Split(' ');
            int aux = words.Length; for (int i = 0; i < aux; i++) 
            { dynamic auxLetra = words.GetValue(0); 
                bool result = words[i + 1].StartsWith(auxLetra); 
                if (result) { Console.WriteLine("verdadeiro"); }
                else { Console.WriteLine("falso"); } } } } }