using System;
using System.Text;
using Biblioteca;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public float CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }
        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }
            return -1;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal = CalcularNotaFinal();
            sb.AppendLine($"Nombre:{nombre}, Apellido: {apellido}, Legajo:{legajo}");
            sb.AppendLine($"Nombre:{nombre}, Apellido: {apellido}");

            if (notaFinal != -1)
            {

            }

        }
    }
}
