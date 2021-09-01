using System;

namespace Biblioteca
{
    public class Boligrafo
    {
        private ConsoleColor color;
        private short tinta;
        private const short cantidadTintaMaxima = 100;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }
       public ConsoleColor GetColor()
        {
            return color;
        }
        public short GetTinta()
        {
            return tinta;
        }
        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if(tinta <0)
            {
                this.tinta = 0;
            }else if(tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }

        }
        public void Recargar()
        {
            tinta = cantidadTintaMaxima;
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";
            if(this.tinta == 0)
            {
                retorno = false;
            }else
            {
                if(this.tinta >= gasto)
                { 
                    for (int i = 0; i < gasto; i++)
                    {
                        dibujo += "*";
                        retorno = true;
                    }
                }
                else
                {
                    for (int i = 0; i < this.tinta; i++)
                    {
                        dibujo += "*";
                        retorno = true;
                    }
                }
                this.tinta -= gasto;
            }
            return retorno;
        }
    }
}
