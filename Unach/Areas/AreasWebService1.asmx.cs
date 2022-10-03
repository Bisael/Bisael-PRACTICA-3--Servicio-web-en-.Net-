using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Areas
{
    /// <summary>
    /// Descripción breve de AreasWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasWebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal Cuadrado(decimal l1, decimal l2)
        {
            Calcular c = new Calcular();
            return c.Cuadrado(l1, l2);
        }
        [WebMethod]
        public decimal Triangulo(decimal b, decimal h)
        {
            Calcular c = new Calcular();
            return c.Triangulo(b, h);
        }
        [WebMethod]
        public double Circulo(double r)
        {
            Calcular c = new Calcular();
            return c.Circulo(r);
        }
    }
}
