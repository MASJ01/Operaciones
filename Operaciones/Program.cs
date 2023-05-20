using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {

            string op = "S";
            int opcion = 0;
            int numero1, numero2;

            do
            {

                Console.Clear();
                Console.Write(titulo());
                Console.SetCursorPosition(0, 4);
                Console.WriteLine("Demostracion \b General");
                Console.Write("DIGITE SU PRIMER NUMERO: ");
                numero1 = int.Parse(Console.ReadLine().ToString());

                Console.WriteLine(" ");

                Console.Write("DIGITE SU SEGUNDO NUMERO: ");
                numero2 = int.Parse(Console.ReadLine().ToString());


                do
                {

                    Console.Clear();
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("DIGITE SU PRIMER NUMERO: " + mostrarprimer(numero1).ToString());
                    Console.WriteLine(" ");
                    Console.WriteLine("DIGITE SU SEGUNDO NUMERO: " + mostrarsegundo(numero2).ToString());
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(45, 15);
                    Console.WriteLine("MENU DE OPERACIONES BASICAS");
                    Console.WriteLine("1.- SUMA DE NUMEROS");
                    Console.WriteLine("2.- RESTA DE NUEMEROS");
                    Console.WriteLine("3.- MULTIPLICACION DE NUMEROS");
                    Console.WriteLine("4.- DIVISION DE NUMEROS");
                    Console.WriteLine("5.- RAIZ CUADRADA");
                    Console.WriteLine("6.- POTENCIA"); //Math.Pow(num1,num2); Se saca la potencia del num1 a la num2
                    //Agregar funciones trigonometricas seno, coseno y tan
                    Console.WriteLine("7.- SALIR"); //(S/N) (La respuesta se debe ver dentro de un parentesis) S se sale y N se regresa
                    Console.WriteLine("8.- FUNCION Sin");
                    Console.WriteLine("9.- FUNCION Cos");
                    Console.WriteLine("10.- FUNCION Tan");
                    opcion = int.Parse(Console.ReadLine().ToString());


                    switch (opcion)
                    {

                        case 1:
                            Console.ForegroundColor = ConsoleColor.Cyan; 
                            Console.WriteLine("LA SUMA DE LOS 2 NUMEROS ES: "+suma(numero1,numero2).ToString()); //Se manda a traer la funcion y se muestra en seguida el resultado. Ya no es necesario mandarla a traer dentro de la funcion.
                            Console.ReadKey();

                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("LA RESTA DE NUMERO 1 MENOS NUMERO 2 ES: " + resta12(numero1, numero2).ToString());
                            Console.WriteLine("LA RESTA DE NUMERO 2 MENOS NUMERO 1 ES: " + resta21(numero1, numero2).ToString());
                            Console.ReadKey(); 

                            break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("LA MULTIPLICACION DE LOS 2 NUMEROS ES: " + multiplicacion(numero1,numero2).ToString());
                            Console.ReadKey(); 

                            break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            if (numero2 != 0)
                            {
                                Console.WriteLine("LA DIVISION DE NUMERO 1 ENTRE NUMERO 2 ES: " + division12(numero1, numero2).ToString());
                            }
                            else
                            {
                                Console.WriteLine("¡ERROR! NO SE PUEDE HACER LA OPERACION DE NUMERO 1 ENTRE NUMERO 2");
                            }


                            if (numero1 != 0)
                            {
                                Console.WriteLine("LA DIVISION DE NUMERO 2 ENTRE NUMERO 1 ES: " + division21(numero1, numero2).ToString());
                            }
                            else
                            {
                                Console.WriteLine("¡ERROR! NO SE PUEDE HACER LA OPERACION DE NUMERO 2 ENTRE NUMERO 1");
                            }

                            Console.ReadKey();

                            break;

                        case 5:
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            if (numero1 >= 0)
                            {
                                Console.WriteLine("LA RAIZ DEL NUMERO 1 ES: " + raiz1(numero1).ToString());
                            }
                            else
                            {
                                Console.WriteLine("¡ERROR! NO SE PUEDE SACAR LA RAIZ DE UN NUMERO NEGATIVO");
                            }


                            if (numero2 >= 0)
                            {
                                Console.WriteLine("LA RAIZ DEL NUMERO 2 ES: " + raiz2(numero2).ToString());
                            }
                            else
                            {
                                Console.WriteLine("¡ERROR! NO SE PUEDE SACAR LA RAIZ DE UN NUMERO NEGATIVO");
                            }

                            Console.ReadKey(); 
                            break;

                        case 6:
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("LA POTENCIA DE NUMERO 1 ELEVADO A LA NUMERO 2 ES: " + potencia12(numero1, numero2).ToString());
                            Console.WriteLine("LA POTENCIA DE NUMERO 2 ELEVADO A LA NUMERO 1 ES: " + potencia21(numero1, numero2).ToString());
                            Console.ReadKey(); 

                            break;

                        case 7:

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(50, 2);
                            Console.WriteLine("SALIR DEL PROGRAMA");
                            Console.Write("Salir (S/N): ");
                            Console.Write("(   )");
                            Console.SetCursorPosition(15, 3);
                            op = Console.ReadLine();

                            if (op.ToUpper() == "S")
                            {
                                Environment.Exit(1);
                            }

                            break;

                        case 8:

                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("LA FUNCION SIN PARA EL NUMERO 1 ES: " + Sin1(numero1).ToString());
                            Console.WriteLine("LA FUNCION SIN PARA EL NUMERO 2 ES: " + Sin2(numero2).ToString());
                            Console.ReadKey(); 

                            break; 

                        case 9:

                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("LA FUNCION COS PARA EL NUMERO 1 ES: " + Cos1(numero1).ToString());
                            Console.WriteLine("LA FUNCION COS PARA EL NUMERO 2 ES: " + Cos2(numero2).ToString());
                            Console.ReadKey(); 

                            break; 

                        case 10:

                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("LA FUNCION TAN PARA EL NUMERO 1 ES: " + Tan1(numero1).ToString());
                            Console.WriteLine("LA FUNCION TAN PARA EL NUMERO 2 ES: " + Tan2(numero2).ToString());
                            Console.ReadKey(); 

                            break; 

                    }

                } while (opcion != 7);

            } while (op.ToUpper() != "S");

        }

        public static string titulo() 
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string titulo1 = "O P E R A C I O N E S";
            Console.SetCursorPosition(((Console.WindowWidth-titulo1.Length)/2),1);
            return titulo1;

        }


        public static int mostrarprimer(int num1)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int numeros = num1;

            return numeros; 

        }

        public static int mostrarsegundo(int num2)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int numeros = num2;

            return numeros;

        }


        public static int suma(int num1, int num2)  //Funcion especifica para retornar un valor
        {
            int resultado = num1 + num2;
            return resultado; 
        }

        public static int resta12(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado; 
        }

        public static int resta21(int num1, int num2)
        {
            int resultado = num2 - num1;
            return resultado; 
        }


        public static int multiplicacion(int num1, int num2)
        {
            int resultado = num1 * num2; // Solo con numeros pequeños, con numeros grandes se declara como double
            return resultado; 
        }

        public static double division12(double num1, double num2) // Es double porque algunas divisiones saldran con numero decimal
        {
            double resultado = (num1 / num2);
            return resultado; 

        }

        public static double division21(double num1, double num2) // La funcion solo ejecuta una accion especifica, no valida nada
        {
            double resultado = (num2 / num1);
            return resultado; 
        }

        public static double raiz1(int num1)
        {
            double resultado = Math.Sqrt(num1);
            return resultado; 
        }

        public static double raiz2(int num2)
        {
            double resultado = Math.Sqrt(num2);
            return resultado;
        }

        public static double potencia12(int num1, int num2)
        {
            double resultado = Math.Pow(num1, num2);
            return resultado; 
        }

        public static double potencia21(int num1, int num2)
        {
            double resultado = Math.Pow(num2, num1);
            return resultado;
            
        }

        public static double Sin1(int num1)
        {
            double resultado = Math.Sin(num1);
            return resultado; 
        }

        public static double Sin2(int num2)
        {
            double resultado = Math.Sin(num2);
            return resultado; 
        }



        public static double Cos1(int num1)
        {
            double resultado = Math.Cos(num1);
            return resultado;
        }

        public static double Cos2(int num2)
        {
            double resultado = Math.Cos(num2);
            return resultado;
        }



        public static double Tan1(int num1)
        {
            double resultado = Math.Tan(num1);
            return resultado;
        }

        public static double Tan2(int num2)
        {
            double resultado = Math.Tan(num2);
            return resultado;
        }



    }
}
