using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8._1.Models
{
    public class Cuenta
    {

        public Cuenta(string nombre, int dni, double importe)
        {
            Nombre = nombre;
            this.DNI = dni;
            this.Importe = importe;
        }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public double Importe { get;  set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, DNI: {DNI}, Importe: {Importe:F2}";
        }

        public int CompareTo(object otherObject)
        {
            Cuenta other = otherObject as Cuenta;
            if (other != null)
            {
                return this.DNI.CompareTo(other.DNI);
            }
            return -1;
        }
    }
}
