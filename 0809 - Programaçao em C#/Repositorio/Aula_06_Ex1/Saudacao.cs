using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_Ex01
{
    class Saudacao
    {
        public void DizerOla(string nome)
        {
            Console.WriteLine($"Olá, {nome}! Bem-vindo(a) ao programa de demonstração.");
        }

        public void DizerAdeus(string nome)
        {
            Console.WriteLine($"Até logo, {nome}! Tenha um bom dia.");
        }
    }
}