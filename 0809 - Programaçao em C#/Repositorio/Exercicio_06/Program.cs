using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    class Program
    {
        static void Main()
        {   
            //Criação das pastas iniciais em ->bin/debug
            string basePath = Path.Combine(Directory.GetCurrentDirectory(), "TechDocs");
            string[] subPastas = { "Relatorios", "Notas", "Logs" };

            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
                Console.WriteLine("Pasta TechDocs criada.");
            }

            foreach (string pasta in subPastas)
            {
                string caminho = Path.Combine(basePath, pasta);
                if (!Directory.Exists(caminho))
                {
                    Directory.CreateDirectory(caminho);
                    Console.WriteLine($"Subpasta criada: {pasta}");
                }
            }

            //Criação dos ficheiros de texto
            string notasPath = Path.Combine(basePath, "Notas");

            string[] nomesFicheiros = { "nota1.txt", "nota2.txt", "nota3.txt" };
            string[] conteudos = {
                "Revisão do código do projeto principal.",
                "Preparar lista de tarefas da semana.",
                "Arquivar relatórios antigos."
            };

            for (int i = 0; i < nomesFicheiros.Length; i++)
            {
                string ficheiro = Path.Combine(notasPath, nomesFicheiros[i]);

                if (!File.Exists(ficheiro))
                {
                    File.WriteAllText(ficheiro, conteudos[i]);
                    Console.WriteLine($"Ficheiro criado: {nomesFicheiros[i]}");
                }
                else
                {
                    Console.WriteLine($"Já existe: {nomesFicheiros[i]}");
                }
            }

            //Ler e listar ficheiros
            Console.WriteLine("\nConteúdo dos ficheiros em Notas:\n");

            string[] ficheiros = Directory.GetFiles(notasPath, "*.txt");

            foreach (string ficheiro in ficheiros)
            {
                string conteudo = File.ReadAllText(ficheiro);
                Console.WriteLine($"[{Path.GetFileName(ficheiro)}] {conteudo}");
            }


            //Criar relatório
            string relatoriosPath = Path.Combine(basePath, "Relatorios");
            string relatorioFile = Path.Combine(relatoriosPath, "relatorio.txt");

            int totalCaracteres = 0;
            foreach (string ficheiro in ficheiros)
            {
                string conteudo = File.ReadAllText(ficheiro);
                totalCaracteres += conteudo.Length;
            }

            using (StreamWriter sw = new StreamWriter(relatorioFile, true))
            {
                sw.WriteLine($"Execução em: {DateTime.Now}");
                sw.WriteLine("Ficheiros lidos:");
                foreach (string ficheiro in ficheiros)
                    sw.WriteLine($" - {Path.GetFileName(ficheiro)}");
                sw.WriteLine($"Total ficheiros: {ficheiros.Length}");
                sw.WriteLine($"Total caracteres: {totalCaracteres}");
                sw.WriteLine(new string('-', 40));
            }

            Console.WriteLine("\nRelatório criado em: " + relatorioFile);
        }
    }
}
