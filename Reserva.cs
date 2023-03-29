using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1DIO
{
    internal class Reserva
    {
        private int _diasReservados;
        private List<Pessoa> _hospedes;
        private Suite _suite;  

        public Reserva(int diasReservados) {
            diasReservados = _diasReservados;
        }

        public string CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count > _suite.Capacidade)
                return "A capacidade da suíte não suporta o número de hóspedes.";
            else {
                foreach (Pessoa pessoa in hospedes)
                {
                    _hospedes.Add(pessoa);
                }
                return "Hospedes cadastrados";
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            _suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return _hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            return _suite.ValorDiaria * _diasReservados;
        }
    }
}
