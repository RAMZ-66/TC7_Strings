using System;
using System.Collections.Generic;

namespace TC7_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor1 = "John";
            string valor2 = valor1.ToLower();

            Console.WriteLine($"\"{valor1} -> \"{valor2}\"");

            string value1 = "Hola";
            // Qué voy a buscar, Por qué lo voy a remplazar
            // Remplazar las "a" por un "4"
            string value2 = value1.Replace("a", "4");
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Hola Mundo";
            value2 = value1.Replace("o", "0");
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            
            Console.WriteLine("-----");

            value1 = "Hola Mundo";
            value2 = value1.Replace("Mundo", "Alumnos");
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "474+621";
            string[] value2array = value1.Split("+");
            Console.WriteLine(value1);
            // Se muestra como System.String[]
            // Console.WriteLine(value2array);

            foreach(string value in value2array)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("-----");

            value1 = "474+621+56+21+457";
            value2array = value1.Split("+");

            Console.WriteLine(value1);
            Console.WriteLine("El resultado del split tiene " + value2array.Length + " strings");

            foreach(string value in value2array)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("-----");

            value1 = "fresa mora frambuesa";
            value2array = value1.Split(" ");
            Console.WriteLine(value1);

            foreach(string value in value2array)
            {
                Console.WriteLine(value);
            }
            
            MostrarEjemploSplit("fresa mora frambuesa", "m");

            MostrarEjemploSplit("fresa mora frambuesa", "m");
            MostrarEjemploSplit("fresa  mora frambuesa", " ");
            MostrarEjemploSplit("fresa  mora frambuesa".Replace("  ", " "), " ");

            MostrarEjemploSplit("1 +4 + 6 +3+5 + 22", "+");
            // Replace(" ", "") -> Borrar espacios
            MostrarEjemploSplit("1 +4 + 6 +3+5 + 22".Replace(" ", ""), "+");

            Console.WriteLine("------");
            
            value1 = " fresa ";
            value2 = value1.Trim();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Peter, Albert, jOHN";
            value2 = value1.ToLower();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Peter, Albert, jOHN";
            value2 = value1.ToUpper();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Peter, Albert, John";
            // value2 = value1.Reverse();
            // Convertir string a char[]
            char[] charArray = value1.ToCharArray();
            // Invertir (reverse) el array
            Array.Reverse( charArray );
            // Crear un nuevo string a partir del char[]
            value2 = new string( charArray );
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");           

            value1 = "Hola Mundo!";
            string substring1 = value1.Substring(0, 4);
            string substring2 = value1.Substring(2, 4);
            string substring3 = value1.Substring(8, 3);
            int indexOf = value1.IndexOf("M");
            int indexOf2 = value1.IndexOf("o");
            int lastIndexOf = value1.LastIndexOf("o");
            Console.WriteLine(value1);
            Console.WriteLine(substring1);
            Console.WriteLine(substring2);
            Console.WriteLine(substring3);
            Console.WriteLine("indexOf: " + indexOf);
            Console.WriteLine("indexOf2: " + indexOf2);
            Console.WriteLine("lastIndexOf: " + lastIndexOf);

            Console.WriteLine("------");

            List <string> nombres = new List<string>();

            nombres.Add("Peter");
            nombres.Add("Albert");
            nombres.Add("John");

            Console.WriteLine("Peter? " + nombres.Contains("Peter")); //True
            Console.WriteLine("bert, Jo? " + nombres.Contains("bert, Jo"));

            // Ejemplo de uso común
            if (nombres.Contains("Peter"))
            {
            // Hacer algo en caso de que si lo contenga
            }

            Console.WriteLine("------");

            value1 = "Peter, Albert, John";
            Console.WriteLine("Peter? " + nombres.Contains("Peter")); // True
            Console.WriteLine("bert, Jo? " + value1.Contains("bert, Jo")); // False

            // Contains + ToLower:

            Console.WriteLine("peter? " + (value1.ToLower()).Contains("peter"));
            
            Console.WriteLine("------");

            value1 = "Peter, Albert, John";

            value2array = value1.Split(", ");

            Array.Reverse(value2array);

            foreach (string val in value2array)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("------");

            value1 = "John";
            value2 = value1.ToLower();
            // "John" -> "john"

            Console.WriteLine("\"John\" -> \"john\"");
            Console.WriteLine("\"{0}\" -> \"{1}\"", value1, value2);
            Console.WriteLine($"\"{value1}\" -> \"{value2}\"");

            

        }

        public static void MostrarEjemploSplit(string valor, string separador)
        {
            Console.WriteLine("------");
            string[] valorArray = valor.Split(separador);

            foreach(string val in valorArray)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("El resultado del split tiene " + valorArray.Length + " strings");

            Console.WriteLine("------");         
            

        }

        
    }
}
