namespace stringcustommethodtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LastIndexOf

            string text1 = "efsane";
            char search1 = 'e';

            Console.WriteLine(StringCustom.LastIndexOf(text1, search1));

            #endregion

            #region Split 

            string text2 = "muavinet";
            char search2 = 'v';

            string[] result = StringCustom.Split(text2, search2);
            foreach (string c in result)
            {
                Console.WriteLine(c);
            }

            #endregion

            #region Replace

            string text = "yusif yaxsi oglandir";
            char search = 'y';
            char replaceChr = 'Y';

            string newText = StringCustom.Replace(text, search, replaceChr);
            Console.WriteLine(newText);

            #endregion

        }
    }
}
