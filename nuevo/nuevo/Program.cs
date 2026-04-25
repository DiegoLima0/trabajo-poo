using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_para_entregar
{
    class CuentaBancaria
    {
        private int _saldo;

        public string Depositar(int monto)
        {

            if (monto > 0)
            {
                _saldo += monto;
                return $"se deposito {monto} y ahora el saldo es {_saldo}";
            }
            else return $"no puede ingresar un monto  negativo a saldo";
        }
        public string Retirar(int monto)
        {
            if (monto > _saldo)
            {
                return $"no puede retirar {monto} de {_saldo}, es insuficiente";
            }
            else
            {
                _saldo = _saldo - monto;
                return $"retirar con exito {monto} del saldo, nuevo saldo: {_saldo}";
            }
        }

    }
    class Temperatura
    {
        private double _celsius;
        public double Celsius
        {
            get => _celsius;
            set
            {
                if (value > -273) _celsius = value;
                else Console.WriteLine("Error: Temperatura por debajo -273 grados celsius.");
            }
        }
    }

    public class Rectangulo
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }
        public double Perimetro => 2 * (Ancho + Alto);
    }

    public class Persona
    {
        public const decimal IVA = 0.21m;

        private readonly int _id;

        private int _edad;
        private string _password;


        public string Password
        {
            set => _password = value;
        }

        public int Edad
        {
            get => _edad;
            set
            {
                if (value >= 0 && value <= 150) _edad = value;
                else Console.WriteLine("Edad fuera de rango");
            }
        }

        public Persona(int idGenerado)
        {
            _id = idGenerado;
        }

        public int Id => _id;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria miCuenta = new CuentaBancaria();

            Console.WriteLine(miCuenta.Depositar(1000));

            Console.WriteLine(miCuenta.Retirar(400));


            Temperatura temp = new Temperatura();
            temp.Celsius = -300;


            Rectangulo rect = new Rectangulo { Ancho = 10, Alto = 5 };
            Console.WriteLine($"Perímetro del rectángulo: {rect.Perimetro}");

            Persona p = new Persona(11);
            p.Edad = 200;
            p.Password = "123456";

            Console.ReadKey();
        }
    }
}
