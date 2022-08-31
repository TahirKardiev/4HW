int Prompt(string text)
{
    Console.Write(text);
    text = Console.ReadLine();
    int result = int.Parse(text);
    return result;
}

int numberslength = Prompt("Enter a count of numbers ");

int [] getNeededMassive( int numbers)
{
    int i = 0;
    int [] arrays = new int [numberslength];
    while  ( i  < numberslength)
    {
        Console.Write ("Enter a number ");
        arrays[i] = int.Parse(Console.ReadLine());
        i++;
    }
    return arrays;
}
int CountOfPossitiveNumbers (int [] arrays)
{
   int count = 0;
   int i = 0;
   while  ( i  < numberslength)
   {
   if (arrays [i] > 0)
        {
            count+= 1;
            i++;
        }   
   else
        {
            count+=0;
            i++;
        }
   }
   return count;
}

int[] array = getNeededMassive(numberslength);
int positiveNumber = CountOfPossitiveNumbers(array);
Console.WriteLine(positiveNumber);