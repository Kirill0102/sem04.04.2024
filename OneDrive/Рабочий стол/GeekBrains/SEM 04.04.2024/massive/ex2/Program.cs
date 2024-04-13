int n = 10;
int[] array = [1,6,24,12,3,14,7,17,11,10];
int i = 0;

while(i < n)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
