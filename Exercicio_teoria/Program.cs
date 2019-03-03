using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_teoria
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabeto, variaveis;
            Dictionary<int, string> digitados = null;
            List<int> ordem = null;
            Tuple<int,string,string> regra;
            char inicio;
            int count = 0;

            Console.WriteLine("Entre com as variaveis (separadas por ,): ");
            string aux = Console.ReadLine();
            variaveis = aux.Replace(",", " ").ToCharArray();

            Console.WriteLine("Entre com o alfabeto (separadas por ,): ");
            aux = Console.ReadLine();
            alfabeto = aux.Replace(",", " ").ToCharArray();

            aux = null;

            while (aux != "0")
            {
                Console.WriteLine("Regras: ");
                aux = Console.ReadLine();
                digitados.Add(count++, aux);
            }
            Console.WriteLine("Ordem das regras: ");
            foreach(KeyValuePair<int, string> valor in digitados)
            {
                Console.WriteLine(valor);
            }
            while(aux != "@")
            {
                Console.WriteLine("Digite a ordem (@ para terminar): ");
                ordem.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}
