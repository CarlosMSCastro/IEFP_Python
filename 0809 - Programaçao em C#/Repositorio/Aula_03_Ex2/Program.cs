using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "José";
            string s =$"O teu nome é {nome}";
            string s2 ="O teu nome é" + nome;
            Console.WriteLine("O teu nome é {0}", nome);

            string numero = "50";
            string data = "1975-09-09";
            int idade = int.Parse(numero); // Texto para num
            double value = double.Parse(numero);
            DateTime datanascimento = DateTime.Parse(data);
            Console.WriteLine(idade.ToString()); // converter para string
            Console.WriteLine(datanascimento.ToString());
            Console.WriteLine(datanascimento.ToString("dd/MM/yyyy"));
        }
    }
}
