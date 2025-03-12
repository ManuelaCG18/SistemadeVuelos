using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos
{
    public class Vuelo
    {
        public string Codigo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public int AsientosDisponibles { get; set; }

        public Vuelo(string codigo, string origen, string destino, DateTime fechaSalida, int asientosDisponibles)
        {
            Codigo = codigo;
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            AsientosDisponibles = asientosDisponibles;
        }

       

        public bool ReservarAsientos(int cantidad)
        {
            if (cantidad <= AsientosDisponibles)
            {
                AsientosDisponibles -= cantidad;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Codigo} | {Origen} -> {Destino} | {FechaSalida:D} | Asientos: {AsientosDisponibles}";
        }
    }
}
