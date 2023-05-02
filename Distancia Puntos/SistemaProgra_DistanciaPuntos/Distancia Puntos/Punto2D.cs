using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProgra_DistanciaPuntos
{
    public class Punto2D : Punto
    {
        public static double x2;
        public static double y2;
        //public static double distancia /*=*/ 0;

        public double X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        public double Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public Punto2D(double xuno, double yuno, double xdos, double ydos)
            : base (xuno, yuno)
        {
            this.X2 = xdos;
            this.Y2 = ydos;
        }

        public static double CalcularDistancia
        {
            get
                {
                return Math.Abs(Math.Sqrt(Math.Pow(y2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            }
        }
    }
}
