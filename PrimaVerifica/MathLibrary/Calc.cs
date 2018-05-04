using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class Calc
    {
        public static double Somma(double a, double b)
        {
            double ris = 0;
            ris = a + b;
            return ris;
        }
        public static double Sottrazione(double a, double b)
        {
            double ris = 0;
            ris = a - b;
            return ris;
        }
        public static double Moltiplicazione(double a, double b)
        {
            double ris = 0;
            ris = a * b;
            return ris;
        }
        public static double Divisione(double a, double b)
        {
            double ris = 0;
            if (a != 0 || b!=0)
            {
                ris = a / b;
            }
            return ris;
        }
        public static double Massimo(double a, double b)
        {
            double ris = 0;
            if (a > b)
            {
                ris = a ;
            }
            else
            {
                ris = b;
            }
            return ris;
        }
        public static double Minimo(double a, double b)
        {
            double ris = 0;
            if (a < b)
            {
                ris = a;
            }
            else
            {
                ris = b;
            }
            return ris;
        }
        public static int[] RaddoppiaContenuto (int[] numero)
        {
            int dimensione = numero.Length;
            int[] ArrayDoppio = new int[dimensione];
            for(int i=0 ; i < dimensione ; i++)
            {
                ArrayDoppio[i] = numero[i] = 2;
            }
            return ArrayDoppio;
        }
    }
}
