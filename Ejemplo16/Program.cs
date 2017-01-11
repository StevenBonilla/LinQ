using Ejemplo16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program : FiguraGeometrica
    {
        public Program(int _altura, int _anchura) : base(_altura, _anchura)
        {
            
        }

        //public double ancho, largo;
        ////Creamos el constructor

        //public Program()
        //{
        //    ancho = 0;
        //    largo = 0;

        //}
        //public Program(double ancho, double largo) //constructor
        //{
        //    this.ancho = ancho;
        //    this.largo = largo;
        //}

        ////Método para la longitud
        //public double calculoLongitud(double largo)
        //{
        //    return largo;
        //}

        ////Metodo para la anchura
        //public double calculoAnchura(double ancho)
        //{
        //    return ancho;
        //}

        ////Calculamos el perimetro del cuadrado pasando como entrada la longitud y la anchura 
        //public double calculoPerimetro(double longitudCuadrado, double longitudAnchura)
        //{
        //    return 2 * longitudCuadrado + 2 * longitudAnchura;
        //}

        ////Calculamos el area del cuadrado introduciendo como entradas el largo y el nacho
        //public double calculoArea(double largoCuadrado, double Anchura)
        //{
        //    return largoCuadrado * Anchura;
        //}



        static void Main()
        {

            //FiguraGeometrica miFigura = devuelveEstructura(5, 8);

            FiguraGeometrica miFigura = new FiguraGeometrica(5, 3);

            //float miArea = miFigura.Area();
            //float miPerimetro = miFigura.Perimetro();
            //int miAltura = miFigura.DevelveAltura();
            //int miAnchura = miFigura.DevuelveAnchura();

        }

        //public static FiguraGeometrica devuelveEstructura(int altura, int anchura)
        //{
        //    FiguraGeometrica nuevaFigura = new FiguraGeometrica(altura, anchura);

        //    return nuevaFigura;
        //}

    }
}
