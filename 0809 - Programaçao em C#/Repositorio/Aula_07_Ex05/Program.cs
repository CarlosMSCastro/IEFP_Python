using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aula_07_Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File : Métodos estáticos para manipular ficheiiros (ler, criar, escrever)
            //FileInfo : Métodos de instância para manipular ficheiros
            //StreamReader : Ler ficheiros de texto linha a linha
            //StreamWrite : Escrever texto em ficheiros
            //Directory : Métodos estáticos para manipular dirétorios
            //DirectoryInfo : Métodos de Instancia para manipular diretorios

            string ficheiro = @"C:\Users\Slyther1n\Desktop\iefp_formacao\0809 - Programaçao em C#\temp\carros.csv";
            //Ler todo o conteudo de um ficheiro de texto
            //Para uma array de strings, onde cada elemento do array é o uma linha do ficheiro
            string[] linhas = File.ReadAllLines(ficheiro,Encoding.UTF8);
            //Contar o numero de linhas do ficheiro
            int totallinhas = linhas.Length;
            
            //Cria uma nova lista de carros
            List<Carro> carros = new List<Carro>();
            //Correr todas as linhas do ficheiro com excepçao da primeira que tem
            //os nomes das colunas

            for (int i = 1; i < totallinhas; i++)
            {
                //Separar os dados da linha pelo caracter vírgula
                string[] dadoslinhas = linhas[i].Split(',');
                //Adicionar um novo carro á lista de carros
                carros.Add(new Carro(
                    int.Parse(dadoslinhas[0]),
                    dadoslinhas[1],
                    dadoslinhas[2],
                    int.Parse(dadoslinhas[3]),
                    dadoslinhas[4],
                    dadoslinhas[5],
                    double.Parse(dadoslinhas[6]),
                    int.Parse(dadoslinhas[7])
                    ));
            }
            //Mostrar os carros lidos do ficheiros e adiciona 5000km
            foreach (Carro carro in carros)
            {
                Console.WriteLine($"{carro.ID} - {carro.Marca}{carro.Modelo}{carro.Ano}{carro.Combustivel}{carro.Cor}{carro.Preco}{carro.Quilometragem}");
                carro.Quilometragem += 5000;
            }
            //Mostra os carros com a quilometragem atualizada
            foreach(Carro carro in carros)
            {
                Console.WriteLine($"{carro.ID} - {carro.Marca}{carro.Modelo}{carro.Ano}{carro.Combustivel}{carro.Cor}{carro.Preco}{carro.Quilometragem}");
            }

        }
    
        class Carro
        {
            public int ID { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Ano { get; set; }
            public string Combustivel { get; set; }
            public string Cor { get; set; }
            public double Preco { get; set; }
            public int Quilometragem { get; set; }

            public Carro(int iD, string marca, string modelo, int ano, string combustivel, string cor, double preco, int quilometragem)
            {
                ID = iD;
                Marca = marca;
                Modelo = modelo;
                Ano = ano;
                Combustivel = combustivel;
                Cor = cor;
                Preco = preco;
                Quilometragem = quilometragem;
            }
        }
    }

}
