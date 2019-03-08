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
            List<Tuple<string, string>> regra = new List<Tuple<string, string>>();
            List<int> instrucoes = new List<int>();
            List<char> alfabeto = new List<char>();
            List<char> variaveis = new List<char>();
            string palavra, aux;
            string[] aux1;

            do
            {
                Console.WriteLine("Digite o alfabeto (0 para sair): ");
                aux = Console.ReadLine();
                alfabeto.Add(Convert.ToChar(aux));
            } while (!aux.Contains('0'));

            aux = null;

            Console.WriteLine("Alfabeto: ", alfabeto);

            do
            {
                Console.WriteLine("Digite as variaveis (0 para sair): ");
                aux = Console.ReadLine();
                variaveis.Add(Convert.ToChar(aux));
            } while (!aux.Contains('0'));

            aux = null;

            Console.WriteLine("Variaveis: ", variaveis);

            do
            {
                Console.WriteLine("Digite a regra de negocio (separado por espaco e 0 para terminar): ");
                aux = Console.ReadLine();
                aux1 = aux.Split(Convert.ToChar(aux), ' ');
                regra.Add(new Tuple<string, string>(aux1[0], aux1[1]));
            } while (!aux.Contains('0'));

            Console.WriteLine("Regra: ", regra);

            aux =  null;
            aux1 = null;

            //TESTE
            //regra.Add(new Tuple<string, string>("S", "XY"));
            //regra.Add(new Tuple<string, string>("X", "XaA"));
            //regra.Add(new Tuple<string, string>("X", "XbB"));
            //regra.Add(new Tuple<string, string>("X", "F"));
            //regra.Add(new Tuple<string, string>("Aa", "aA"));
            //regra.Add(new Tuple<string, string>("Ab", "bA"));
            //regra.Add(new Tuple<string, string>("AY", "Ya"));
            //regra.Add(new Tuple<string, string>("Ba", "aB"));
            //regra.Add(new Tuple<string, string>("Bb", "bB"));
            //regra.Add(new Tuple<string, string>("BY", "Yb"));
            //regra.Add(new Tuple<string, string>("Fa", "aF"));
            //regra.Add(new Tuple<string, string>("Fb", "bF"));
            //regra.Add(new Tuple<string, string>("FY", ""));

            do
            {
                Console.WriteLine("Digite os passos a serem seguidos (q para terminar): ");
                aux = Console.ReadLine();
                instrucoes.Add(Convert.ToInt32(aux));
            } while (!aux.Contains('q'));

            //TESTE
            //instrucoes.Add(0);
            //instrucoes.Add(1);
            //instrucoes.Add(6);
            //instrucoes.Add(2);
            //instrucoes.Add(7);
            //instrucoes.Add(9);
            //instrucoes.Add(3);
            //instrucoes.Add(11);
            //instrucoes.Add(10);
            //instrucoes.Add(12);
            //string palavra = "S";

            Console.WriteLine("Qual a palavra inicial: ");
            palavra = Console.ReadLine();

            palavra = formar(regra, palavra, instrucoes);

            Console.WriteLine(palavra);
            Console.ReadLine();
        }

        public static string formar(List<Tuple<string, string>>regra, string palavra, List<int> instrucoes)
        {
            foreach (var ins in instrucoes)
            {
                palavra = palavra.Replace(regra[ins].Item1, regra[ins].Item2);
            }
            return palavra;
        } 
    }
}
