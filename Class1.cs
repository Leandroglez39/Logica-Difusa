using System;
using System.Collections.Generic;
using System.Globalization;

namespace Utiles
{
    public class Class1
    {
        #region Diccionario

        public Dictionary<string, double> Datos = new Dictionary<string, double>();

        #endregion

        #region Variables

        public enum Peso
        {
            lijero,
            promedio,
            pesado

        }

        public enum Velocidad
        {
            lento,
            normal,
            rapido
        }

        public enum Rosamiento
        {
            nulo,
            optimo,
            alto
        }

        public enum Frenado
        {
            poco,
            normal,
            mucho
        }

        #endregion

        #region Funsiones

        public static double Trapezoidal(double x, double a, double b, double c, double d)
        {

            var o1 = x - a;
            var o2 = b - a;
            var o3 = d - x;
            var o4 = d - c;
            return Math.Max(Math.Min(o1 / o2, Math.Min(1, o3 / o4)), 0);



        }

        private static double And(double x, double y)
        {
            return Math.Min(x, y);
        }

        private static double Or(double x, double y)
        {
            return Math.Max(x, y);
        }

        public void ProcesadoVelocidad(double x)
        {
            var lento = Trapezoidal(x, 0, 10, 30, 40);
            var normal = Trapezoidal(x, 0, 40, 70, 90);
            var rapido = Trapezoidal(x, 0, 90, 200, 500);

            Datos.Add(Velocidad.lento.ToString(), lento);
            Datos.Add(Velocidad.normal.ToString(), normal);
            Datos.Add(Velocidad.rapido.ToString(), rapido);

        }

        public void ProcesadoRosamiento(double x)
        {
            var nulo = Trapezoidal(x, 0, 10, 20, 30);
            var optimo = Trapezoidal(x, 0, 30, 45, 50);
            var alto = Trapezoidal(x, 0, 50, 100, 101);

            Datos.Add(Rosamiento.nulo.ToString(), nulo);
            Datos.Add(Rosamiento.optimo.ToString(), optimo);
            Datos.Add(Rosamiento.alto.ToString(), alto);

        }

        public void ProcesadoPeso(double x)
        {

            var lijero = Trapezoidal(x, 0, 200, 400, 450);
            var promedio = Trapezoidal(x, 0, 450, 1200, 1300);
            var pesado = Trapezoidal(x, 0, 1300, 2000, 4000);


            Datos.Add(Peso.lijero.ToString(), lijero);
            Datos.Add(Peso.promedio.ToString(), promedio);
            Datos.Add(Peso.pesado.ToString(), pesado);
        }

        public void ProcesandoFrenado(double x)
        {
            var poco = Trapezoidal(x, 0, 20, 30, 40);
            var normal = Trapezoidal(x, 0, 40, 60, 70);
            var mucho = Trapezoidal(x, 0, 70, 100, 101);

            Datos.Add(Frenado.normal.ToString(), normal);
            Datos.Add(Frenado.poco.ToString(), poco);
            Datos.Add(Frenado.mucho.ToString(), mucho);

        }

        #endregion

        #region Reglas/

        public void Regla1(string a, string b, string c)
        {



        }

        public void Regla2(string a, string b, string c)
        { }

        public void Regla3(string a, string b, string c)
        { }
        public void Regla4(string a, string b, string c)
        { }
        public void Regla5(string a, string b, string c)
        { }
        public void Regla6(string a, string b, string c)
        { }
        public void Regla7(string a, string b, string c)
        { }
        public void Regla8(string a, string b, string c)
        { }
        public void Regla9(string a, string b, string c)
        { }
        public void Regla10(string a, string b, string c)
        { }
        public void Regla11(string a, string b, string c)
        { }
        public void Regla12(string a, string b, string c)
        { }
        public void Regla13(string a, string b, string c)
        { }
        public void Regla14(string a, string b, string c)
        { }
        public void Regla15(string a, string b, string c)
        { }
        public void Regla16(string a, string b, string c)
        { }
        public void Regla17(string a, string b, string c)
        { }

        public void Regla18(string a, string b, string c)
        { }
        public void Regla19(string a, string b, string c)
        { }
        public void Regla20(string a, string b, string c)
        { }



        #endregion
    }
}
