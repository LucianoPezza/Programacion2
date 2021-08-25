using System;
using Calculadora;
namespace Calculadora
{
    public static class Calculodora
    {
        public static decimal Calcular(int primerOp, int segundoOp, char operacion)
        {
            decimal resultado=0;

            switch(operacion)
            {
                case '+' :
                      resultado = primerOp + segundoOp;
                      break;
                case '-':
                      resultado = primerOp - segundoOp;
                      break;
                case '*':
                      resultado = primerOp * segundoOp;
                      break;
                case '/':
                    if (Validar(segundoOp))resultado = primerOp / segundoOp;
                    else
                    {
                        Console.WriteLine("Error,el segundo operando no puede ser 0 en una division.");
                    }

                    break;
            }


            return resultado;
        }
    private static bool Validar(int segundoOperando)
        {
            bool retorno= false;
            if (segundoOperando != 0) retorno = true;
            return retorno;
        }
    }
}
