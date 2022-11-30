Console.WriteLine("Write number" );
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма" + GetSumNum(num));
int GetSumNum(int input);
{
    int sum = input 0;
    while(input > 0)
    {sum+= input % 10;
    input= input / 10;}

return sum;
}
