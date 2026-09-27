using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa para calcular N aumentos salariales de una empresa....

            string cedula = string.Empty;
            string nombre = string.Empty;
            byte tipo_empleado = 0;
            float horas_trabajadas = 0;
            float precio_hora = 0;
            float salario = 0;
            float aumento = 0;
            float salario_bruto = 0;
            float CCSS = 0;
            float salario_neto = 0;

            int cantidad_empleados = 0;
            int cantidad_tipo1 = 0;
            int cantidad_tipo2 = 0;
            int cantidad_tipo3 = 0;

            float total_salario_ordinario = 0;
            float total_salario_bruto = 0;
            float total_salario_neto = 0;

            char opcion = 's';

            do
            {
                cantidad_empleados++;

                Console.Write("Ingrese su número de cédula: ");
                cedula = Console.ReadLine();

                Console.Write("Ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("1. Operario");
                Console.WriteLine("2. Técnico");
                Console.WriteLine("3. Profesional");
                Console.Write("Ingrese el tipo de empleado: ");
                tipo_empleado = byte.Parse(Console.ReadLine());

                switch (tipo_empleado)
                {
                    case 1:
                        aumento = 0.15f;
                        cantidad_tipo1++;
                        break;

                    case 2:
                        aumento = 0.10f;
                        cantidad_tipo2++;
                        break;

                    case 3:
                        aumento = 0.05f;
                        cantidad_tipo3++;
                        break;

                    default:
                        Console.WriteLine("Tipo de empleado incorrecto.");
                        break;
                }

                Console.Write("Ingrese el número de horas trabajadas: ");
                horas_trabajadas = float.Parse(Console.ReadLine());

                Console.Write("Ingrese el precio de la hora trabajada: ");
                precio_hora = float.Parse(Console.ReadLine());

                if ((tipo_empleado >= 1 && tipo_empleado <= 3) && horas_trabajadas > 0 && precio_hora > 0 && !string.IsNullOrEmpty(cedula) && !string.IsNullOrEmpty(nombre))
                {
                    salario = horas_trabajadas * precio_hora;

                    aumento = salario * aumento;

                    salario_bruto = salario + aumento;

                    CCSS = salario_bruto * 0.0917f;

                    salario_neto = salario_bruto - CCSS;

                    total_salario_ordinario += salario;
                    total_salario_bruto += salario_bruto;
                    total_salario_neto += salario_neto;

                    Console.WriteLine();
                    Console.WriteLine($"La cédula del empleado es: {cedula}");
                    Console.WriteLine($"El nombre del empleado es: {nombre}");
                    Console.WriteLine($"El tipo de empleado es: {tipo_empleado}");
                    Console.WriteLine($"El salario por hora del empleado es: {precio_hora}");
                    Console.WriteLine($"El número de horas trabajadas es: {horas_trabajadas}");
                    Console.WriteLine($"El salario ordinario es: {salario}");
                    Console.WriteLine($"El aumento es: {aumento}");
                    Console.WriteLine($"El salario bruto es: {salario_bruto}");
                    Console.WriteLine($"El descuento de la CCSS es: {CCSS}");
                    Console.WriteLine($"El salario neto es: {salario_neto}");
                }
                else
                {
                    Console.WriteLine("Datos incorrectos.");
                }

                Console.WriteLine();
                Console.Write("¿Desea ingresar otro empleado? (s/n): ");
                opcion = char.Parse(Console.ReadLine());

                Console.WriteLine();

            } while (opcion == 's' || opcion == 'S');

            Console.WriteLine($"Cantidad de empleados: {cantidad_empleados}");
            Console.WriteLine($"Cantidad de Operarios: {cantidad_tipo1}");
            Console.WriteLine($"Cantidad de Técnicos: {cantidad_tipo2}");
            Console.WriteLine($"Cantidad de Profesionales: {cantidad_tipo3}");
            Console.WriteLine($"Total salarios ordinarios: {total_salario_ordinario}");
            Console.WriteLine($"Total salarios brutos: {total_salario_bruto}");
            Console.WriteLine($"Total salarios netos: {total_salario_neto}");
        }
    }
}
