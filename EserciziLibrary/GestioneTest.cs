using System;


namespace EserciziLibrary
{
    public class GestioneTest
    {
        public static double Sconto(double numero)
        {
            return numero / 100 * 10;
        }
        public static double Incremento(double numero, double inc)
        {
            double incremento = numero * inc / 100;
            double risultato = numero + incremento;
            return risultato;
        }
    }
}
