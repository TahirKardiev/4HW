int Prompt(string text)
{
    Console.Write(text);
    text = Console.ReadLine();
    int result = int.Parse(text);
    return result;
}

int [] getNeededMassive( int numbers)
{
    int i = 0;
    int numberslength = Prompt("Enter a count of numbers ");
    int [] arrays = new int [numberslength];
    while  ( i  < numberslength)
    {
        Console.Write ("Enter a number ");
        arrays[i] = int.Parse(Console.ReadLine());
      
    }
    return arrays;
}
int CountOfPossitiveNumbers (int [] arrays)
{
   int count = 0;
   int i = 0;
   if (arrays [i] > 0)
        {
            count+= 1;
            i++;
        } 
    return count;
}

