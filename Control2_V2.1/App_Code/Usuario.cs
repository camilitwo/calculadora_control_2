using System;

namespace mis_clases
{
    public class Usuario
    {
        private string _nombre;
        private string _clave;

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Clave
        {
            get
            {
                return _clave;
            }

            set
            {
                _clave = value;
            }
        }
    }

    public class Calculadora : Operaciones
    {

        public double MostrarDivision()
        {
            return Division();
        }


        public double MostrarMultiplicacion()
        {
            return Multiplicacion();
        }

        public double MostrarResta()
        {
            return Resta();
        }

        public double MostrarSuma()
        {
            return Suma();
        }

    }

    public class Operaciones
    {
        private int _num1;
        private int _num2;

        public double Division()
        {
            return Math.Round(((double)_num1 / (double)_num2), 3);
        }

        public void ingresaNumeros(int a, int b)
        {
            _num1 = a;
            _num2 = b;
        }

        public int GetNum1()
        {
            return _num1;
        }

        public int GetNum2()
        {
            return _num2;
        }

        public double Multiplicacion()
        {
            return _num1 * _num2; 
        }

        public double Resta()
        {
            return _num1 - _num2;
        }

        public double Suma()
        {
            return _num1 + _num2;
        }
    }
}