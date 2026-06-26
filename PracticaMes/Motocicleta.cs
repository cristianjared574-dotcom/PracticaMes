using PracticaMes.Instancia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMes.Instancia
{
    internal class Motocicleta : Estacionamiento
    {
        //Atributo
        public int Cilindrada { get; set; }

        //constructor 
        public Motocicleta(string Tipo_vehiculo,int HorasIngresadas, int cilidrada) : base(Tipo_vehiculo, HorasIngresadas)
        {
            cilidrada = Cilindrada;
        }

        //tarifa
        public override float calcularPrecioFinal()
        {
            float tarifaPorHora = 15.00f;
            return HorasEstacionamiento * tarifaPorHora;
        }
    }
}
