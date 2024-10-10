namespace Methods;

    internal class Program
{
    static void Main(string[] args)
    {
        string text = "Hello my name is Afsana";
        string searching = "name";
        bool end = CustomCharAt(text, searching);
        Console.WriteLine(end);
    }
        
    public static bool CustomCharAt(string text, string searching)
    {
        for (int i = 0; i <= text.Length - searching.Length; i++)
        {
            int j = 0;
            for(j = 0; j < searching.Length; j++)
            {
                if (text[i+j] != searching[j])
                {
                    break;
                }
                
            }
            if (j == searching.Length)
            { return true; }
        }
        return false;
    }
}
























