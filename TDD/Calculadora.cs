using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class Calculadora
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }

        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        public double Dividir(int x, int y)
        {
            return x / y;
        }

        public int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public List<double> Historico(int x, int y)
        {
            List<double> lista = new List<double>();
            lista.Add(Somar(x, y));
            lista.Add(Subtrair(x, y));
            lista.Add(Dividir(x, y));
            lista.Add(Multiplicar(x, y));
            return lista;
        }
    }
}
