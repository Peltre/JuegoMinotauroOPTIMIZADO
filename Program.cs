
//Hacemos el juego del Minotauro implementando Arrays y AFD
//Programa OPTIMIZADO 
//Autor: Pedro Jesús Sotelo Arce - A01285371
//Ultima modificación 15/04/2024

using System;
using Microsoft.VisualBasic;

namespace dotnet
{
    public class Program
    {
        public static void Main()
        {
            //setup
            int[,] Laberinto = new int[,]{{0,0,0,0},{0,2,0,0},{3,0,1,4},{0,2,5,0},{0,0,5,2},{0,4,6,3},{0,0,5,7}};
            char [] habitaciones = new char[] {'X','E','A','B','F','C','D','T'};
            char[] direcciones = new char[] {'n','s','o','e'};

            char direccion;
            int direccionInt;

            char habitacionActual = 'E';
            int habitacionActualInt;

            ConsoleKeyInfo movimiento;

            int paso;
            bool fin = false;

            do{
                //Instrucciones
                Console.WriteLine("Introduce uan dirección");
                Console.WriteLine("Habitacion actual:" + habitacionActual);

                //Lectura de tecla que presione el usuario
                movimiento = Console.ReadKey(true);

                direccion = Char.ToLower(movimiento.KeyChar); //Convertimos en minusculas

                //Obtenemos el indice dentro del array para direccion y habitacion
                direccionInt = Array.IndexOf(direcciones, direccion);
                habitacionActualInt = Array.IndexOf(habitaciones, habitacionActual);
                
                //Busque los indices en la matriz laberinto para comprobar si hay mov
                paso = Laberinto[habitacionActualInt,direccionInt];
                

                switch(paso)
                {
                    //Caso por si no hay movimiento
                    case 0:
                    Console.Write("camino bloqueado");
                    break;
                    
                    //Caso de encontrarse con el minotauro (Habitacion B con indice 3)
                    case 3:
                    Console.Write("Te ha atrapado el minotauro, supongo que no eras Teseo");
                    fin = true;
                    break;

                    //Caso de encontrar el tesoro (Habitacion T con indice 7)
                    case 7:
                    Console.Write("Has encontrado el tesoro, una hazaña digna de los dioses!");
                    fin = true;
                    break;

                    //Si existe movimiento actualizamos la variable habitacion actual
                    default:
                    habitacionActual = habitaciones[paso];
                    break;

                }

            }while(fin != true);

        }
    }
}
