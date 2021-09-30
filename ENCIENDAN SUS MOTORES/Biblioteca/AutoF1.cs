using System;

namespace Biblioteca
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short CaballosDeFuerza;

       
        public AutoF1(short numero, string escuderia)
        :base(numero, escuderia)
        {
            base.CantidadCombustible = 0;
            base.VueltasRestantes = 0;
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
        :this(numero,escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }
        public short CaballosFuerza
        {
            get { return this.CaballosDeFuerza; }
            set { this.CaballosDeFuerza = value; }
        }

        public string MostrarDatos()
        {
            return $"El auto numero: {base.Numero}" +
                $"Escuderia: {base.Escuderia}" +
                $"El Combustible: {base.CantidadCombustible}" +
                $"Vueltas restantes: {base.VueltasRestantes}";
        }
        public static bool operator ==(AutoF1 a1,AutoF1 a2)
        {
            return (a1.Escuderia == a2.Escuderia) && (a1.Numero == a2.Numero) && (a1.CaballosFuerza == a2.CaballosFuerza);
        }
        public static bool operator !=(AutoF1 a1,AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }

}
