using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoRecursiva {
    internal class Program {
        static void Main(string[] args) {

            Console.Title = "Programado por JulianoMarthins";

            Console.WriteLine("-=-=-=-=-= Calculadora de Fatoriais -=-=-=-=-=\n");
            Console.Write("Digite o número a ser calculado: ");

            int num = int.Parse(Console.ReadLine());

            int resultado = Fator.Fatorial(num);

            Console.WriteLine($"O fator de {num} foi {resultado}\n");
            

        }
    }
}
