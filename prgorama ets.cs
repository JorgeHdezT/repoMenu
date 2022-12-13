/* Crea un programa que escriba por pantalla: "Hola, que quieres hacer" y muestre un menú que la opcion 1 sea sumar 2 numeros y se llame suma. La opcion 2 sea resta y reste 2 numeros. y una opcion llamada salir, para cuando se pulse 0. El programa no termina hasta pulsar 0. En C#*/

using System;

public class Ejercicio_2_1_1_1
{
	public static void Main()
	{
		int opcion;
		
		Console.WriteLine("Hola, que quieres hacer?");
		Console.WriteLine("1- Sumar 2 numeros");
		Console.WriteLine("2- Restar 2 numeros");
		Console.WriteLine("0- Salir");
		
		opcion=Convert.ToInt32(Console.ReadLine());
		
		while(opcion!=0)
		{
			switch(opcion)
			{
				case 1:
					Suma();
					break;
				case 2:
					Resta();
					break;
				default:
					Console.WriteLine("Opcion incorrecta");
					break;
			}
			Console.WriteLine("Hola, que quieres hacer?");
			Console.WriteLine("1- Sumar 2 numeros");
			Console.WriteLine("2- Restar 2 numeros");
			Console.WriteLine("0- Salir");
			
			opcion=Convert.ToInt32(Console.ReadLine());
		}
	}
	
	public static void Suma()
	{
		int num1, num2;
		
		Console.WriteLine("Ingrese el primer numero");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese el segundo numero");
		num2=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("La suma es: {0}", num1+num2);
	}
	
	public static void Resta()
	{
		int num1, num2;
		
		Console.WriteLine("Ingrese el primer numero");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese el segundo numero");
		num2=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("La resta es: {0}", num1-num2);
	}
}