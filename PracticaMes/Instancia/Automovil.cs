using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMes.Instancia
{
    internal class Automovil : Estacionamiento
    {
        public string Placa { get; set; }

        public Automovil(string Tipo_vehiculo, int horas, string placa) : base(Tipo_vehiculo, horas)
        {
            this.Placa = placa;
        }
        public override float calcularPrecioFinal()
        {
            return HorasEstacionamiento * 30.00f;
        }
    }
}
