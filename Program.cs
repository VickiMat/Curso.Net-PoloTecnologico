using System;
using System.Globalization;

int[,] carton = new int[3,9];

Random rand = new Random();

int[] values = new int[27];
int comodin = 0;
string repeat = "y";

Console.WriteLine("Welcome to the bingo game!");
while (repeat == "y")
{
    for (int i = 0; i < 9; i++)
    { // asignamos los numeros random por columna
        switch (i)
        {
            case 0:
                carton[0, i] = rand.Next(1, 10);
                carton[1, i] = rand.Next(1, 10);
                carton[2, i] = rand.Next(1, 10);
                break;
            case 1:
                carton[0, i] = rand.Next(10, 20);
                carton[1, i] = rand.Next(10, 20);
                carton[2, i] = rand.Next(10, 20);
                break;
            case 2:
                carton[0, i] = rand.Next(20, 30);
                carton[1, i] = rand.Next(20, 30);
                carton[2, i] = rand.Next(20, 30);
                break;
            case 3:
                carton[0, i] = rand.Next(30, 40);
                carton[1, i] = rand.Next(30, 40);
                carton[2, i] = rand.Next(30, 40);
                break;
            case 4:
                carton[0, i] = rand.Next(40, 50);
                carton[1, i] = rand.Next(40, 50);
                carton[2, i] = rand.Next(40, 50);
                break;
            case 5:
                carton[0, i] = rand.Next(50, 60);
                carton[1, i] = rand.Next(50, 60);
                carton[2, i] = rand.Next(50, 60);
                break;
            case 6:
                carton[0, i] = rand.Next(60, 70);
                carton[1, i] = rand.Next(60, 70);
                carton[2, i] = rand.Next(60, 70);
                break;
            case 7:
                carton[0, i] = rand.Next(70, 80);
                carton[1, i] = rand.Next(70, 80);
                carton[2, i] = rand.Next(70, 80);
                break;
            case 8:
                carton[0, i] = rand.Next(80, 90);
                carton[1, i] = rand.Next(80, 90);
                carton[2, i] = rand.Next(80, 90);
                break;
            default:
                break;
        }


        for (int j = 0; j < 3; j++)
        {

            if (i == 0)
            {
                //comprobamos que no haya numeros repetidos

                while (carton[0, i] == carton[1, i] || carton[0, i] == carton[2, i] || carton[1, i] == carton[2, i])
                {
                    carton[0, i] = rand.Next(1, 10);
                    carton[1, i] = rand.Next(1, 10);
                    carton[2, i] = rand.Next(1, 10);
                }

                //ordenando los numeros de menor a mayor por columna
                if (carton[0, i] > carton[1, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[1, i];
                    carton[1, i] = comodin;
                }
                else if (carton[0, i] > carton[2, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
                else if (carton[1, i] > carton[2, i])
                {
                    comodin = carton[1, i];
                    carton[1, i] = carton[2, i];
                    carton[2, i] = comodin;
                }

            }
            else if (i == 1)
            {
                //comprobamos que no haya numeros repetidos
                while (carton[0, i] == carton[1, i] || carton[0, i] == carton[2, i] || carton[1, i] == carton[2, i])
                {
                    carton[0, i] = rand.Next(10, 20);
                    carton[1, i] = rand.Next(10, 20);
                    carton[2, i] = rand.Next(10, 20);
                }
                //ordenando los numeros de menor a mayor por columna
                if (carton[0, i] > carton[1, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[1, i];
                    carton[1, i] = comodin;
                }
                else if (carton[0, i] > carton[2, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
                else if (carton[1, i] > carton[2, i])
                {
                    comodin = carton[1, i];
                    carton[1, i] = carton[2, i];
                    carton[2, i] = comodin;
                }

            }
            else if (i == 2)
            {   //comprobamos que no haya numeros repetidos
                while (carton[0, i] == carton[1, i] || carton[0, i] == carton[2, i] || carton[1, i] == carton[2, i])
                {
                    carton[0, i] = rand.Next(20, 30);
                    carton[1, i] = rand.Next(20, 30);
                    carton[2, i] = rand.Next(20, 30);
                }
                //ordenando los numeros de menor a mayor por columna
                if (carton[0, i] > carton[1, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[1, i];
                    carton[1, i] = comodin;
                }
                else if (carton[0, i] > carton[2, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
                else if (carton[1, i] > carton[2, i])
                {
                    comodin = carton[1, i];
                    carton[1, i] = carton[2, i];
                    carton[2, i] = comodin;
                }

            }
            else if (i == 3)
            {   //comprobamos que no haya numeros repetidos
                while (carton[0, i] == carton[1, i] || carton[0, i] == carton[2, i] || carton[1, i] == carton[2, i])
                {
                    carton[0, i] = rand.Next(30, 40);
                    carton[1, i] = rand.Next(30, 40);
                    carton[2, i] = rand.Next(30, 40);
                }
                //ordenando los numeros de menor a mayor por columna
                if (carton[0, i] > carton[1, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[1, i];
                    carton[1, i] = comodin;
                }
                else if (carton[0, i] > carton[2, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
                else if (carton[1, i] > carton[2, i])
                {
                    comodin = carton[1, i];
                    carton[1, i] = carton[2, i];
                    carton[2, i] = comodin;
                }

            }
            else if (i == 4)
            {   //comprobamos que no haya numeros repetidos
                while (carton[0, i] == carton[1, i] || carton[0, i] == carton[2, i] || carton[1, i] == carton[2, i])
                {
                    carton[0, i] = rand.Next(40, 50);
                    carton[1, i] = rand.Next(40, 50);
                    carton[2, i] = rand.Next(40, 50);
                }
                //ordenando los numeros de menor a mayor por columna
                if (carton[0, i] > carton[1, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[1, i];
                    carton[1, i] = comodin;
                }
                else if (carton[0, i] > carton[2, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
                else if (carton[1, i] > carton[2, i])
                {
                    comodin = carton[1, i];
                    carton[1, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
            }
            else if (i == 5)
            {   //comprobamos que no haya numeros repetidos
                while (carton[0, i] == carton[1, i] || carton[0, i] == carton[2, i] || carton[1, i] == carton[2, i])
                {
                    carton[0, i] = rand.Next(50, 60);
                    carton[1, i] = rand.Next(50, 60);
                    carton[2, i] = rand.Next(50, 60);
                }
                //ordenando los numeros de menor a mayor por columna
                if (carton[0, i] > carton[1, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[1, i];
                    carton[1, i] = comodin;
                }
                else if (carton[0, i] > carton[2, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
                else if (carton[1, i] > carton[2, i])
                {
                    comodin = carton[1, i];
                    carton[1, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
            }
            else if (i == 6)
            {   //comprobamos que no haya numeros repetidos
                while (carton[0, i] == carton[1, i] || carton[0, i] == carton[2, i] || carton[1, i] == carton[2, i])
                {
                    carton[0, i] = rand.Next(60, 70);
                    carton[1, i] = rand.Next(60, 70);
                    carton[2, i] = rand.Next(60, 70);
                }
                //ordenando los numeros de menor a mayor por columna
                if (carton[0, i] > carton[1, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[1, i];
                    carton[1, i] = comodin;
                }
                else if (carton[0, i] > carton[2, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
                else if (carton[1, i] > carton[2, i])
                {
                    comodin = carton[1, i];
                    carton[1, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
            }
            else if (i == 7)
            {   //comprobamos que no haya numeros repetidos
                while (carton[0, i] == carton[1, i] || carton[0, i] == carton[2, i] || carton[1, i] == carton[2, i])
                {
                    carton[0, i] = rand.Next(70, 80);
                    carton[1, i] = rand.Next(70, 80);
                    carton[2, i] = rand.Next(70, 80);
                }
                //ordenando los numeros de menor a mayor por columna
                if (carton[0, i] > carton[1, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[1, i];
                    carton[1, i] = comodin;
                }
                else if (carton[0, i] > carton[2, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
                else if (carton[1, i] > carton[2, i])
                {
                    comodin = carton[1, i];
                    carton[1, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
            }
            else if (i == 8)
            {   //comprobamos que no haya numeros repetidos
                while (carton[0, i] == carton[1, i] || carton[0, i] == carton[2, i] || carton[1, i] == carton[2, i])
                {
                    carton[0, i] = rand.Next(80, 90);
                    carton[1, i] = rand.Next(80, 90);
                    carton[2, i] = rand.Next(80, 90);
                }
                //ordenando los numeros de menor a mayor por columna
                if (carton[0, i] > carton[1, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[1, i];
                    carton[1, i] = comodin;
                }
                else if (carton[0, i] > carton[2, i])
                {
                    comodin = carton[0, i];
                    carton[0, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
                else if (carton[1, i] > carton[2, i])
                {
                    comodin = carton[1, i];
                    carton[1, i] = carton[2, i];
                    carton[2, i] = comodin;
                }
            }
        }
    }


    //GENERATE BLANK SPACES RANDOM
    int blankSpace = 12;

    int countZero1 = 0, countZero2 = 0, countZero3 = 0;

    for (int i = 0; i < 9; i++)
    {//Asignar un 0 a cada columna
        bool columnZero = false;
        while (!columnZero)
        {
            int rowRandom = rand.Next(0, 3);

            if (rowRandom == 0 && countZero1 < 4)
            {
                carton[rowRandom, i] = 0;
                blankSpace--;
                countZero1++;
                columnZero = true;
            }
            if (rowRandom == 1 && countZero2 < 4)
            {
                carton[rowRandom, i] = 0;
                blankSpace--;
                countZero2++;
                columnZero = true;
            }
            if (rowRandom == 2 && countZero3 < 4)
            {
                carton[rowRandom, i] = 0;
                blankSpace--;
                countZero3++;
                columnZero = true;
            }
        } 
    }
    //completar con 0 segun la consigna
    while (blankSpace > 0)
    {
        int rowBlank = rand.Next(0, 3);
        int columnBlank = rand.Next(0, 9);


        if (carton[rowBlank, columnBlank] == 0)
        {
            continue;
        }

        int zeroInRow = 0;
        for (int c = 0; c < 9; c++)
        {
            if (carton[rowBlank, c] == 0)
            {
                zeroInRow++;
            }
        }

        int zeroinColumn = 0;
        for (int f = 0; f < 3; f++)
        {
            if (carton[f, columnBlank] == 0)
            {
                zeroinColumn++;
            }
        }


        if (zeroInRow >= 4 || zeroinColumn >= 2)
        {
            continue;
        }

        else
        {
            carton[rowBlank, columnBlank] = 0;
            blankSpace--;
        }

    }

    //mostrar en pantalla

    for (int f = 0; f < 3; f++)
    {
        Console.WriteLine(" ----------------------------------------------------------------------");

        for (int c = 0; c < 9; c++)
        {
            if (carton[f, c] < 10 && carton[f, c] != 0)
            {
                Console.Write(" | 0" + carton[f, c] + " | ");
            }
            else if (carton[f, c] == 0)
            {
                Console.Write(@" |    | ");
            }

            else Console.Write(" | " + carton[f, c] + " | ");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine(" ----------------------------------------------------------------------");
    Console.WriteLine("Do you wanna generate another bingo? y/n");
    repeat = Console.ReadLine().ToLower();
}


