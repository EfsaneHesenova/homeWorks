#region task1
Console.WriteLine("olcusunu daxil edin:");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());  
}
int CurenLength = arr.Length;
for (int i = 0; i<CurenLength; i++)
{
    int menfieded = arr[i] * -1;
    Array.Resize(ref arr, arr.Length + 1);
    arr[arr.Length - 1] = menfieded;
}
foreach (int a in arr)
{ 
    Console.WriteLine(a); 
}
#endregion



//Add the form of the odd numbers in the array increased by 5 units, and the form of the even numbers decreased by 3 units to the array

#region task2
Console.WriteLine("olcusunu daxil edin:");
int a = int.Parse(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
int CurenLength = arr.Length;

for (int i = 0; i < CurenLength; i++)
{
    Array.Resize(ref arr, arr.Length + 1);
    if (i % 2 != 0)
    {
        int cut = arr[i] - 3;
        arr[arr.Length - 1] = cut;
    }
    else
    {
        int tek = arr[i] + 5;
        arr[arr.Length - 1] = tek;
    }
}
foreach (int b in arr)
{
    Console.WriteLine(b);
}
#
#endregion
























