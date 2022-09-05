Console.WriteLine("Please, insert the lenght of the vector");

int vectorLenght = int.Parse(Console.ReadLine());
int[] firstVector = new int[vectorLenght];

Random randomNumbers = new Random();

Console.WriteLine("The numbers are: ");

for (int i = 0; i < vectorLenght; i++)
{
    firstVector[i] = randomNumbers.Next(200);
    Console.WriteLine(firstVector[i]);

}


Console.WriteLine("New order: ");
int changing = vectorLenght-1;
for (int j = 0; j<vectorLenght ; j++)
{
    if(firstVector[j] == firstVector[changing])
    {
        break;
    }
    int auxiliar = firstVector[j];
    firstVector[j] = firstVector[changing];
    firstVector[changing] = auxiliar;    
    changing = changing  - 1;
}

for (int j = 0; j < vectorLenght; j++)
{
    Console.WriteLine($"{firstVector[j]}");
}




