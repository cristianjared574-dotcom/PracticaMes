using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMes.Instancia
{
    public abstract class Estacionamiento
    {
        public string Tipovehiculo { get; set; }
        public int HorasEstacionamiento { get; set; }

        public Estacionamiento(string Tipo_vehiculo, int horas_estacionamiento)
        {
            Tipovehiculo = Tipo_vehiculo;
            HorasEstacionamiento = horas_estacionamiento;
        }

        public abstract float calcularPrecioFinal();
    }
}
