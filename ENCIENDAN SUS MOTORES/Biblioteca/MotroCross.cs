using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MotroCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotroCross(short numero, string escuderia)
        :base(numero,escuderia)
        {

        }
        public MotroCross(short numero, string escuderia, short cilindrada)
        :this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }
        public string MostrarDatos()
        {
            return $"El auto numero: {base.Numero}" +
                $"Escuderia: {base.Escuderia}" +
                $"El Combustible: {base.CantidadCombustible}" +
                $"Vueltas restantes: {base.VueltasRestantes}";
        }
        public static bool operator ==(MotroCross m1, MotroCross m2)
        {
            return (m1.Escuderia == m2.Escuderia) && (m1.Numero == m2.Numero) &&(m1.Cilindrada == m2.Cilindrada);
        }
        public static bool operator !=(MotroCross m1, MotroCross m2)
        {
            return !(m1 == m2);
        }
    }
}
