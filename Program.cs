using System;

namespace parcia1
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int Id = 0;
                String Codigo;
                String Nombre;
                int Edad;
                String control = "Sí";
                String control2 = "Si";
                int índice = 0;
                int Nota1;
                int Nota2;
                int NotaFinal;
                int Opciones;
                string Dato;
                string Cerrar;

                Estudiantes[] arregloestudiantes = new Estudiantes[1];

                while (control == "Sí")
                {
                    Console.WriteLine("Ingrese los siguientes datos:");
                    Console.WriteLine("Ingrese el Código:");
                    Codigo = Console.ReadLine();
                    Console.WriteLine("Ingrese el Nombre:");
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad:");
                    Edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Nota1:");
                    Nota1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Nota2:");
                    Nota2 = int.Parse(Console.ReadLine());

                    NotaFinal = (Nota1 + Nota2) / 2;

                    arregloestudiantes[índice] = new Estudiantes(Id, Codigo, Nombre, Edad, Nota1, Nota2, NotaFinal);
                    Id = Id + 1;
                    Console.WriteLine("Desea agregar otro registro (Si, No): ");
                    control = Console.ReadLine();
                    if (control == "Si")
                    {
                    }
                    índice = índice + 1;
                    Array.Resize(ref arregloestudiantes, arregloestudiantes.Length + 1);
                    {
                    }
                else { control = "No"; }
                }


                while (control2 == "Si")
                {
                    Console.WriteLine("Desea consultar por Aprobados: Digite 1");
                    Console.WriteLine("Desea consultar por Reprobados: Digite 2");
                    Console.WriteLine("Desea consultar por Codigo: Digite 3");
                    Opciones = int.Parse(Console.ReadLine());
                    if (Opciones == 1)
                    {
                        IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                       where estudiante.NotaFinal >= 6
                                                                       select estudiante;
                        foreach (Estudiantes consulta in consultaestudiantes)
                        {
                            Console.WriteLine(consulta.mostrar());

                        }
                    }
                    else if (Opciones == 2)
                    {
                        IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                       where estudiante.NotaFinal < 6
                                                                       select estudiante;
                        foreach (Estudiantes consulta in consultaestudiantes)
                        {
                            Console.WriteLine(consulta.mostrar());

                        }
                    }
                    else if (Opciones == 3)
                    {
                        Console.WriteLine("Digite el codigo del estudiante: ");
                        Dato = Console.ReadLine();

                        IEnumerable<object> enumerable2 = from estudiante in arregloestudiantes;
                        IEnumerable<object> enumerable1 = enumerable2;
                        IEnumerable<object> enumerable = enumerable1;
                        IEnumerable<Estudiantes> consultaestudiantes = (IEnumerable<Estudiantes>)enumerable;
                        Codigo == Dato
                        foreach (var consulta in consultaestudiantes)
                        {
                            Console.WriteLine(consulta.mostrar());

                        }
                    }
                    Console.WriteLine("Desea continuar: Si, No");
                    Cerrar = Console.ReadLine();
                    if (Cerrar == "No")
                    {
                        control2 = "No";
                    }
                }

                Console.Read();
            }
    }
}
