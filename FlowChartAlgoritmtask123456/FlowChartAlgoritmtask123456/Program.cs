#region task1
int num = 453;
if (num > 99 && num < 1000)
{
    int num1 = num / 100;
    int num2 = (num / 10) % 10;
    int num3 = num % 10;
    int sum = num1 + num2 + num3;
    if (sum % 2 == 0)
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }
}
else
{
    Console.WriteLine("The mode you entered is not correct");
}
#endregion

#region task2
int num = 3513;


if (num > 999 && num < 10000)
{
    int thousand = num / 1000;
    int hundred = (num / 100) % 10;
    int dec = (num / 10) % 10;
    int sing = num % 10;
    int sum = thousand + hundred + dec + sing;
    Console.WriteLine(sum / 4);
}
#endregion


#region task3
int num = 555;


if (num > 99 && num < 1000)
{
    int hundred = num / 100;
    int dec = (num / 10) % 10;
    int sing = num % 10;
    int sum = hundred + dec + sing;

    if (sum % 3 == 0 && sum % 5 == 0)
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }
}
else
{
    Console.WriteLine("please write three-digit number");
}
#endregion


#region task4
float gpa = 93.8f;

switch (gpa)
{
    case float n when (n <= 100f && n >= 91f):
        Console.WriteLine("A");
        break;
    case float n when (n >= 81f && n < 91f):
        Console.WriteLine("B");
        break;
    case float n when (n >= 71f && n < 81f):
        Console.WriteLine("C");
        break;
    case float n when (n >= 61f && n < 71f):
        Console.WriteLine("D");
        break;
    case float n when (n >= 51f && n < 61f):
        Console.WriteLine("E");
        break;
    default:
        Console.WriteLine("F");
        break;
}
#endregion

#region task5
int num1 = 4;
int num2 = 5;

if (num1 % 2 == 0 && num2 % 2 == 0)
{
    Console.WriteLine(num1 + num2);
}
else
{
    Console.WriteLine(num1 - num2);
}
#endregion


#region task6
loat salary = 800f;
float credit = 3300f;
if (credit > salary * 12 * 0.6)
{
    Console.WriteLine("false");
}
else
{
    Console.WriteLine("true");
}
#endregion region
