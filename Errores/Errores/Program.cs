using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciacion de una lista de la clase alumno
            var alumno = new List<Alumno>();
            var agregar = true;
            while (agregar)//ciclo para agregar alumnos
            {
                try
                {
                    //Instanciacion de la variable temp de tipo alumno
                    var temp = new Alumno();
                    //Se crea una variable para almacenar un resultado de tipo bool con el cual comprobar si el numero ingresado es de tipo int
                    var NumeroControl = temp.Id;
                    //ciclo para verificar si el numero de control es de tipo int, de no serlo se le pedira al usuario que ingrese un numero en vez de una letra
                    while (NumeroControl == 0)
                    {
                        Console.WriteLine("Ingrese No de control");
                        //Se genera la respuesta usada en el ciclo y en el if siguiente
                        bool result = int.TryParse(Console.ReadLine(), out NumeroControl);
                        if (NumeroControl == 0)
                        {
                            Console.WriteLine("Ingrese un numero, no otro tipo de caracter");
                        }                     
                    }
                   
                    Console.WriteLine("Ingrese Nombre");
                    temp.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese Carrera");
                    temp.Carrera = Console.ReadLine();
                    Console.WriteLine("Ingrese su semestre");
                    temp.Semestre = Console.ReadLine();
                    alumno.Add(temp);                 
                    Console.WriteLine("¿Desea agregar un alumno màs? (Si/No)");
                    //If  para saber si el usuario desea agregar mas alumnos
                    if (Console.ReadLine() != "Si")
                    {
                        agregar = false;
                    }
                }
                catch(Exception e)
                {
                    //Se le indica al usuario que hubo problemas detectando su error
                    Console.WriteLine("Error agregando el usuario");
                }
            }
            Console.ReadKey();
            //Conclusion: Este tipo de herramientas nos permiten poder resolver errores durante la ejecucion de un programa 
            //y asi poder informarle al usuario de que es lo que esta pasando, para que pueda realizar alguna clase de correcion
        }
    }
}
