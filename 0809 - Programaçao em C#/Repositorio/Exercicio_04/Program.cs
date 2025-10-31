using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitLifeApp
{
    class Program
    {
        static void Main()
        {
            string[] dias = { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo" };

            int[] calorias = LerCalorias(dias);
            int total = CalcularTotalSemanal(calorias);
            double media = CalcularMediaDia(calorias);
            int MaisIntenso = DiaMaisIntenso(calorias);

            MostrarResumo(dias, calorias, total, media, MaisIntenso);
        }

        static int[] LerCalorias(string[] dias)
        {
            int[] calorias = new int[dias.Length];

            for (int i = 0; i < dias.Length; i++)
            {
                Console.Write($"Calorias gastas {dias[i]}: ");
                calorias[i] = int.Parse(Console.ReadLine());
            }

            return calorias;
        }

        static int CalcularTotalSemanal(int[] calorias)
        {
            int total = 0;
            foreach (int c in calorias)
                total += c;
            return total;
        }

        static double CalcularMediaDia(int[] calorias)
        {
            return (double)CalcularTotalSemanal(calorias) / calorias.Length;
        }

        static int DiaMaisIntenso(int[] calorias)
        {
            int indice = 0;
            for (int i = 1; i < calorias.Length; i++)
            {
                if (calorias[i] > calorias[indice])
                    indice = i;
            }
            return indice;
        }

        static void MostrarResumo(string[] dias, int[] calorias, int total, double media, int indiceMaisIntenso)
        {
            Console.WriteLine("\n=== Resumo Semanal ===");
            Console.WriteLine($"Total semanal: {total} calorias");
            Console.WriteLine($"Média diária: {media:F1} calorias");
            Console.WriteLine($"Dia mais intenso: {dias[indiceMaisIntenso]} ({calorias[indiceMaisIntenso]} cal)");
        }
    }
}
