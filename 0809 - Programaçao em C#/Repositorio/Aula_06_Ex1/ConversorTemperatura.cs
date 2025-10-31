using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_Ex01
{
    class ConversorTemperatura
    {
        public double CelsiusParaFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}
