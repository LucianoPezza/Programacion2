using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        public enum eTipoCompetencia { F1, MotroCross };
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private eTipoCompetencia tipoCompetencia;
        private List<VehiculoDeCarrera> competidores;
        public Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores,eTipoCompetencia tipoCompetencia)
        : this()
        {
            this.CantidadCompetidores = cantidadCompetidores;
            this.CantidadVueltas = cantidadVueltas;
            this.TipoCompetencia = tipoCompetencia;
        }

        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        public eTipoCompetencia TipoCompetencia { get => tipoCompetencia; set => tipoCompetencia = value; }
       
        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool returnAux = false;
            if (c.TipoCompetencia == Competencia.eTipoCompetencia.F1 && v.GetType() == typeof(AutoF1)||(c.tipoCompetencia==Competencia.eTipoCompetencia.MotroCross && v.GetType()== typeof(MotroCross))) 
            {
                if(c.competidores.Count > 0)
                { 
                foreach (VehiculoDeCarrera vehiculo in c.competidores)
                {
                    if (vehiculo == v)
                    {
                        returnAux = true;
                        break;
                    }
                }
                }
            }
            else
            {
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c1, VehiculoDeCarrera v)
        {
            Random combustibleRandom = new Random();
            bool returnAux = false;
            if (c1 != v && c1.competidores.Count < c1.CantidadCompetidores)
            {
                v.EnCompetencia = true;
                v.CantidadCombustible = (short)combustibleRandom.Next(15, 100);
                v.VueltasRestantes= c1.CantidadVueltas;
                c1.competidores.Add(v);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator -(Competencia c1, VehiculoDeCarrera v)
        {
            bool returnAux = false;
            if(c1==v)
            {
                c1.competidores.Remove(v);
                returnAux = true;
            }
            return returnAux;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de vueltas en la competencia {this.CantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores {this.CantidadCompetidores}");
            foreach (VehiculoDeCarrera vehiculo in this.competidores)
            {
                if(vehiculo.GetType()==typeof(AutoF1))
                {
                    sb.AppendLine(((AutoF1)vehiculo).MostrarDatos());
                }
                else if(vehiculo.GetType() == typeof(MotroCross))
                {
                    sb.AppendLine(((MotroCross)vehiculo).MostrarDatos());
                }

            }  
            return sb.ToString();
        }
    }

}