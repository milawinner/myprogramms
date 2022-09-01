Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());
int PositiveIndex = 2;
int NegativeIndex = -2;

if (num > 1)
{
    while(PositiveIndex < num)
    {
        Console.Write(PositiveIndex); Console.Write(", ");
        PositiveIndex += 2;
    }
}
if (num > -2 & num <= 1)
{
    Console.WriteLine("В диапазоне от 1 до введённого числа нет чётных чисел");
}
else
{
    while(NegativeIndex > num)
    {
        Console.Write(NegativeIndex); Console.Write(", ");
        NegativeIndex -= 2;
    }
    Console.WriteLine(num); 
}
