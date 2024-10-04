#region task1

int[] nums = { 133, 3, 4, 8, 11, 12, 15 };
int say = 0;
for (int i = 0; i < 7; i++)
{
    say ++;
    
}
Console.WriteLine(say);

#endregion



#region task2

int[] num2 = { 3, 8, 12, 24, 30, 33, 11 };
int same = 12;
int tocheck = 0;
for (int i = 0; i < num2.Length; i++)
{
    if (num2[i] == same)
    { tocheck++; }
}
if (tocheck > 0)
{
    Console.WriteLine("true");
}
else 
{ Console.WriteLine("false"); }


#endregion

#region task3

int[] num = {3,8,12,24,30,33,11,12};
int copy = 12;
int check = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] == copy)
    { check++; }
}


Console.WriteLine(check);

#endregion

