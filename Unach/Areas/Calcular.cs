using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Areas
{
    public class Calcular
    {
        
        public decimal Cuadrado(decimal l1, decimal l2)
        {
            return l1 * l2;
        }
        public decimal Triangulo(decimal b, decimal h)
        {
            var Area = b * h / 2;
            return Area;
        }
        public double Circulo(double radio)
        {
            double Radio = radio;
            double area;
            area = (Radio * radio) * Math.PI;
            return area;
        }
    }
}