using System;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El precio es:{p.precio}");
            sb.AppendLine($"Su marca es:{p.marca}");
            sb.AppendLine($"El codigo de barra es:{p.codigoDeBarra}");

            return sb.ToString();
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {

            if(!(p1 is null || p2 is null))
            {
                return p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca;
            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);

        }
    }
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacionEstante)
        : this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }
        public Producto[] GetProducto()
        {
            return productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion: {e.ubicacionEstante}");
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (!(e.productos[i] is null))
                {
                    sb.AppendLine(Producto.Mostrar(e.productos[i]));
                }
            }
            return sb.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p) return true;
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)// si el producto agregado no esta en el estante entro al if.
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)//si esta posicion no tiene nada agrego el producto.
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {         
                    if(e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }
        

    }
}