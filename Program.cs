
int[,] numeros;

Console.WriteLine("Ingrese la cantidad de columnas para la matriz numeros");
int columnasNumeros = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de filas para la matriz numeros");
int filasNumeros = int.Parse(Console.ReadLine());

numeros = new int[filasNumeros, columnasNumeros];

double[] promedios = new double[columnasNumeros];

//Longitudes en cada dimensión
int columnaLenght = numeros.GetUpperBound(1) + 1;
int filaLenght = numeros.GetUpperBound(0) + 1;

//Ingreso de datos a la matriz
for (int columna = 0; columna < columnaLenght; columna++)
{
    Console.WriteLine($"Ingrese los datos para la columna número {columna+1}");

	for (int fila = 0; fila < filaLenght; fila++)
	{
		Console.WriteLine($"y la fila número {fila+1}:");
		numeros[fila,columna]= int.Parse(Console.ReadLine());
	}
}

Console.WriteLine("-------------------------------");
//Mostrar todos los valores almacenados 
for (int fila = 0; fila < filaLenght; fila++)
{
	Console.WriteLine($"Estamos mostrando los valores de la fila {fila+1}");
	for (int columna = 0; columna < columnaLenght; columna++)
	{
		Console.WriteLine($"en la columna {columna+1}");
		Console.WriteLine($"{numeros[fila,columna]}");
	}
}

Console.WriteLine("-------------------------------");

int[] sumaColumnas = new int[columnasNumeros];

for (int columna = 0; columna < columnaLenght; columna++)
{
    for (int fila = 0; fila < filaLenght; fila++)
    {
		sumaColumnas[columna] = sumaColumnas[columna] + numeros[fila,columna];
    }
	promedios[columna] = sumaColumnas[columna] / filaLenght;
}

for (int i = 0; i < promedios.Length; i++)
{
	Console.WriteLine($"El promedio de la columna {i+1} es {promedios[i]}");
}
