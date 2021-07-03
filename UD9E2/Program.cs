using System;

namespace UD9E2
{
    class Empleado
    {
        int sueldo;

        string nombre;
        public Empleado()
        {
            Console.WriteLine("Introduzca el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el sueldo del empleado");
            string linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Sueldo:" + sueldo);
        }

        public void Impuestos()
        {
            if (sueldo >= 3000)
            {
                Console.WriteLine(nombre + " debe pagar impuestos.");
            }
            else
            {
                Console.WriteLine(nombre + " no debe pagar impuestos.");
            }
        }

        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            empleado1.Mostrar();
            empleado1.Impuestos();
            Console.ReadKey();
        }
    }
}
