using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1DIO
{
    internal class Suite
    {
        private string _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            _tipoSuite = tipoSuite;
            _capacidade = capacidade;
            _valorDiaria = valorDiaria;
        }

        public decimal ValorDiaria => _valorDiaria;
        public decimal Capacidade => _capacidade;

    }
}
