using System.Diagnostics;

namespace I.OBoundTask
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Stopwatch st = Stopwatch.StartNew();
                List<string> urls = new List<string>
                {
                "https://www.w3schools.com/",
                "https://www.youtube.com/",
                "https://avtovagzal.az/page/tarifler"

                };
                SyncProgram(urls);
                Console.WriteLine(st.ElapsedMilliseconds);
                Console.WriteLine("--------------------------------------------------------------");
                st.Restart();

                AsyncProgram(urls).Wait();
                Console.WriteLine(st.ElapsedMilliseconds);

            }
            public static void SyncProgram(List<string> urls)
            {
                HttpClient httpClient = new HttpClient();
                foreach (string item in urls)
                {
                    httpClient.GetStringAsync(item).Result.ToString();
                }
            }
            public static async Task AsyncProgram(List<string> urls)
            {
                HttpClient httpClient = new HttpClient();

                List<Task<string>> tasks = new List<Task<string>>();

                foreach (string item in urls)
                {
                    tasks.Add(httpClient.GetStringAsync(item));
                }
                await Task.WhenAll(tasks);
            }
        }
    }
