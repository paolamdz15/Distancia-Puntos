using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProgra_DistanciaPuntos
{
    public class Punto
    {
        public static double x1;
        public static double y1;

        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        public double Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        public Punto(double xuno, double yuno)
        {
            this.X1 = xuno;
            this.Y1 = yuno;
        }
      

    }
 
}
