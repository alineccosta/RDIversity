using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Tabuada");

		for (int x = 1; x <= 10; x++)
		{
			Console.WriteLine("\nTabuada do " + x);

			for (int contador = 1; contador <= 10; contador++)
			{
				int resultado = (x * contador);
				Console.WriteLine(x + " x " + contador + " = " + resultado);
			}
		}
	}
}