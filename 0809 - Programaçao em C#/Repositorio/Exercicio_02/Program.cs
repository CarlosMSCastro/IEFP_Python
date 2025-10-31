using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DB
            List<Funcionario> funcionarios = new List<Funcionario>();
            FuncionarioEfetivo fe1 = new FuncionarioEfetivo() { Nome = "Cristiano Ronaldo", Cargo = "CallCenter", SalarioMensal = 925 };
            FuncionarioEfetivo fe2 = new FuncionarioEfetivo() { Nome = "Bernardo Silva", Cargo = "Team Leader", SalarioMensal = 1325 };
            FuncionarioEfetivo fe3 = new FuncionarioEfetivo() { Nome = "Victor Froholdt", Cargo = "Faz Tudo", SalarioMensal = 1600 };
            FuncionarioHorista fh1 = new FuncionarioHorista() { Nome = "Lionel Messi", Cargo = "Jardineiro", HorasTrabalhadas = 95, ValorHora = 12 };
            FuncionarioHorista fh2 = new FuncionarioHorista() { Nome = "Rui Costa", Cargo = "Jardineiro Junior", HorasTrabalhadas = 140, ValorHora = 6 };
            FuncionarioHorista fh3 = new FuncionarioHorista() { Nome = "Noronha Lopes", Cargo = "Motorista", HorasTrabalhadas = 40, ValorHora = 16 };

            funcionarios.Add(fe1);
            funcionarios.Add(fe2);
            funcionarios.Add(fe3);
            funcionarios.Add(fh1);
            funcionarios.Add(fh2);
            funcionarios.Add(fh3);

            // while
            while (true)
            {
                Console.WriteLine("\n=== Adicionar Novo Funcionário ===");
                Console.Write("Nome: ");
                string nome = Console.ReadLine().Trim();

                Console.Write("Cargo: ");
                string cargo = Console.ReadLine().Trim();

                string tipo;
                do
                {
                    Console.Write("Tipo (E=Efetivo, H=Horista, S=Estagiario): ");
                    tipo = Console.ReadLine().Trim().ToUpper();
                } while (tipo != "E" && tipo != "H" && tipo != "S");

                if (tipo == "E")
                {
                    Console.Write("Salário Mensal: ");
                    double salario = double.Parse(Console.ReadLine());
                    funcionarios.Add(new FuncionarioEfetivo { Nome = nome, Cargo = cargo, SalarioMensal = salario });
                }
                else if (tipo == "H")
                {
                    Console.Write("Horas Trabalhadas: ");
                    int horas = int.Parse(Console.ReadLine());

                    Console.Write("Valor por Hora: ");
                    double valorHora = double.Parse(Console.ReadLine());

                    funcionarios.Add(new FuncionarioHorista { Nome = nome, Cargo = cargo, HorasTrabalhadas = horas, ValorHora = valorHora });
                }
                else
                {
                    Console.Write("Horas Trabalhadas: ");
                    int horas = int.Parse(Console.ReadLine());

                    Console.Write("Bolsa Fixa: ");
                    double bolsa = double.Parse(Console.ReadLine());

                    funcionarios.Add(new Estagiario { Nome = nome, Cargo = cargo, HorasTrabalhadas = horas, BolsaFixa = bolsa });
                }

                Console.Write("Deseja adicionar outro funcionário? (S/N): ");
                string resp = Console.ReadLine().Trim().ToUpper();
                if (resp != "S") break;
            }

            
            Console.WriteLine("\n<<<<<<<< Lista de Funcionários >>>>>>>>");
            foreach (Funcionario f in funcionarios)
            {
                Console.WriteLine($"{f.Nome}, {f.Cargo}, Salário: {f.CalcularSalario():F2}");
            }

            // Matematica
            double[] salarios = new double[funcionarios.Count];
            for (int i = 0; i < funcionarios.Count; i++)
                salarios[i] = funcionarios[i].CalcularSalario();

            double media = salarios.Average();
            double max = salarios.Max();
            double min = salarios.Min();

            Console.WriteLine($"\nSalário médio: {media:F2}");
            Console.WriteLine($"Salário mais alto: {max:F2}");
            Console.WriteLine($"Salário mais baixo: {min:F2}");

            //Criador do .txt de exportação 
            string caminhoArquivo = "funcionarios.txt";

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.WriteLine("Lista de Funcionários:");
                sw.WriteLine("---------------------");

                foreach (Funcionario f in funcionarios)
                {
                    sw.WriteLine($"{f.Nome}, {f.Cargo}, Salário: {f.CalcularSalario():F2}");
                }

                sw.WriteLine();
                sw.WriteLine($"Salário médio: {media:F2}");
                sw.WriteLine($"Salário mais alto: {max:F2}");
                sw.WriteLine($"Salário mais baixo: {min:F2}");
            }

            Console.WriteLine($"\nDados exportados com sucesso para Repos/NomedoProjeto/bin/Debug/{caminhoArquivo}!");


        }
    }
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public abstract double CalcularSalario();

        public void MostrarDados()
        {
            Console.WriteLine($"{Nome} - {Cargo}");
        }

    }
    class FuncionarioEfetivo : Funcionario
    {
        public double SalarioMensal {  get; set; }

        public override double CalcularSalario()
        {
            return SalarioMensal;
        }
    }
    class FuncionarioHorista : Funcionario
    {
        public int HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public override double CalcularSalario()
        {
            return HorasTrabalhadas * ValorHora;
        }
    }

    class Estagiario : Funcionario
    {
        public double BolsaFixa { get; set; }
        public int HorasTrabalhadas { get; set; }

        public override double CalcularSalario()
        {
            return BolsaFixa + (HorasTrabalhadas * 3);
        }
    }
}
