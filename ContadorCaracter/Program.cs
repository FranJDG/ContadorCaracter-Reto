using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorCaracter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "akjfubnvdsokinaasoinogfinbffoskinasa";

            Console.WriteLine("Este es el texto: " + text);

            Console.WriteLine("Que letra quieres buscar y contar?");

            string comparar = Console.ReadLine();

            string caracter = "";

            int contador = 0;

            for (int i = 0; i < text.Length; i++)
            {
                caracter = Convert.ToString(text[i]);

                if (caracter == comparar)
                {
                    contador++;
                }
            }

            Console.WriteLine("Hay " + contador + " letras " + comparar);

            //Otra forma
            contador = 0;

            foreach(var c in text)
            {
                if(comparar == Convert.ToString(c))
                {
                    contador++;
                }
            }
            Console.WriteLine("Resultado con la forma 2.");
            Console.WriteLine(contador);

            //Otra forma
            contador = 0;

            contador = text.Where(c => c == Convert.ToChar(comparar)).Count();

            Console.WriteLine("Resultado con la forma 3.");
            Console.WriteLine(contador);

        }
    }
}
