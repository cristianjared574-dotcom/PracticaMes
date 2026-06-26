using System;

namespace PracticaMes.Instancia
{
    /// <summary>
    /// Integrante D: Clase Camioneta
    /// Tarifa: $45.00 por hora
    /// </summary>
    public class Camioneta : Estacionamiento
    {
        // Atributo específico solicitado
        public int NumeroEjes { get; set; }

        // Constructor
        public Camioneta(string tipoVehiculo, int horasEstancia, int numeroEjes): base(tipoVehiculo, horasEstancia)
        {
            NumeroEjes = numeroEjes;
        }

        // Método sobrescrito con el nombre exacto que usa tu formulario
        public override float calcularPrecioFinal()
        {
            const float tarifaPorHora = 45.00f;
            return HorasEstacionamiento * tarifaPorHora;
        }
    }
}