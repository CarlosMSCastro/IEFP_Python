using System;
using System.IO;


namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("../../ClinicaSorrisoFeliz/Pacientes");
            Directory.CreateDirectory("../../ClinicaSorrisoFeliz/Backup");

            while (true)
            {
                Console.WriteLine("=== Clínica Sorriso Feliz ===");
                Console.WriteLine("1 - Criar novo paciente");
                Console.WriteLine("2 - Registar nova consulta");
                Console.WriteLine("3 - Listar consultas de um paciente");
                Console.WriteLine("4 - Efetuar backup");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "0") break;

                switch (opcao)
                {
                    case "1":
                        CriarPaciente();
                        break;
                    case "2":
                        RegistarConsulta();
                        break;
                    case "3":
                        ListarConsultas();
                        break;
                    case "4":
                        EfetuarBackup();
                        break;
                    default:
                        Console.WriteLine("Insira uma opção válida\n");
                        break;
                }
            }
        }

        static void CriarPaciente()
        {   
            Console.Write("Insira o nome do paciente: ");
            string nome = Console.ReadLine();
            Directory.CreateDirectory($"../../ClinicaSorrisoFeliz/Pacientes/{nome}");

            using (StreamWriter sw = new StreamWriter($"../../ClinicaSorrisoFeliz/Pacientes/{nome}/dados.txt"))
            {
                sw.WriteLine($"Nome: {nome}");
                sw.WriteLine($"Data de Registo: {DateTime.Now.ToString("yyyy-MM-dd")}\n");
            }
            Console.WriteLine("Paciente Registado.\n");
        }

        static void RegistarConsulta()
        {
            string[] pacientes = Directory.GetDirectories("../../ClinicaSorrisoFeliz/Pacientes");
            if (pacientes.Length == 0)
            {
                Console.WriteLine("Nenhum paciente Registado.\n");
                return;
            }

            Console.WriteLine("Pacientes Disponíveis: \n");
            for (int i = 0; i<pacientes.Length; i++)
                Console.WriteLine($"{i+1} - {Path.GetFileName(pacientes[i])}");

            Console.WriteLine("Escolha o paciente: ");
            int escolha = int.Parse(Console.ReadLine());

            using (StreamWriter sw = new StreamWriter($"{pacientes[escolha - 1]}/consultas.txt", true))
            {
                Console.Write("Data da Consulta (yyyy-MM-dd): ");
                string data = Console.ReadLine();
                Console.Write("Tipo de tratamento: ");
                string tratamento = Console.ReadLine();
                Console.Write("Valor (€): ");
                string valor = Console.ReadLine();

                sw.WriteLine($"Data: {data}");
                sw.WriteLine($"Tratamento: {tratamento}");
                sw.WriteLine($"Valor: {valor}\n");
            }
            Console.WriteLine("Consulta Registada.\n");
        }

        static void ListarConsultas()
        {
            string[] pacientes = Directory.GetDirectories("../../ClinicaSorrisoFeliz/Pacientes");
            if (pacientes.Length == 0)
            {
                Console.WriteLine("Nenhum paciente Registado.\n");
                return;
            }

            Console.WriteLine("Pacientes Disponíveis: \n");
            for (int i = 0; i < pacientes.Length; i++)
                Console.WriteLine($"{i + 1} - {Path.GetFileName(pacientes[i])}");

            Console.WriteLine("Escolha o paciente: ");
            int escolha = int.Parse(Console.ReadLine());

            if (!File.Exists($"{pacientes[escolha - 1]}/consultas.txt"))
            {
                Console.WriteLine("Nenhum consulta registada.\n");
                return;
            }
            Console.WriteLine($"\nConsultas de {Path.GetFileName(pacientes[escolha - 1])}:\n");

            using (StreamReader sr = new StreamReader($"{pacientes[escolha - 1]}/consultas.txt"))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                    Console.WriteLine(linha);
            }
            Console.WriteLine();

        }
        
        static void EfetuarBackup()
        {
            if (!Directory.Exists("../../ClinicaSorrisoFeliz/Pacientes"))
            {
                Console.WriteLine("A pasta de pacientes não existe. \n");
                return;
            }

            string nomeBackup = $"Backup_{DateTime.Now.ToString("yyyy-MM-dd_HHmm")}";

            Directory.CreateDirectory($"../../ClinicaSorrisoFeliz/Backup/{nomeBackup}");
            CopiarPastas("../../ClinicaSorrisoFeliz/Pacientes", $"../../ClinicaSorrisoFeliz/Backup/{nomeBackup}");

            Console.WriteLine("Backup criado!\n");
        }
        static void CopiarPastas(string origem, string destino)
        {
            foreach (string ficheiro in Directory.GetFiles(origem))
            {
                string nome = Path.GetFileName(ficheiro);
                File.Copy(ficheiro, $"{destino}/{nome}", true);
            }
            foreach (string subpasta in Directory.GetDirectories(origem))
            {
                string nome = Path.GetFileName(subpasta);
                Directory.CreateDirectory($"{destino}/{nome}");
                CopiarPastas(subpasta, $"{destino}/{nome}");
            }
        }
    }   
}
