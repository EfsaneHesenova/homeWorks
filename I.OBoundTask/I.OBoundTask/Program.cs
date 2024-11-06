using DirectoryFiletask1.Models;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;


namespace I.OBoundTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*#region IO bound Main
            Stopwatch st = Stopwatch.StartNew();
            List<string> urls = new List<string>
            {
                "https://www.w3schools.com/",
                "https://www.youtube.com/",
                "https://avtovagzal.az/page/tarifler"
            };
            SyncProgram(urls);
            Console.WriteLine(st.ElapsedMilliseconds);
            st.Restart();
            ASyncProgram(urls);
            Console.WriteLine(st.ElapsedMilliseconds);

            #endregion*/

            #region Directory/File Task Main
            string url = "https://jsonplaceholder.typicode.com/posts";
            string path = @"C:\Users\User\source\repos\I.OBoundTask\I.OBoundTask";
            Directory.CreateDirectory(path + @"\Models");
            Directory.CreateDirectory(path + @"\Data");
            if (!File.Exists(path + @"\Data\jsonData.json"))
            {
                File.Create(path + @"\Data\jsonData.json");
            }
            else
            {
                Console.WriteLine("Already exists");
            }

            if (!File.Exists(path + @"\Models\Info.cs"))
            {
                File.Create(path + @"\Models\Info.cs");
            }
            else
            {
                Console.WriteLine("Already exists");
            }

            string data = AsyncProgramReturn(url).Result;

            List<Info> datas = JsonConvert.DeserializeObject<List<Info>>(data);

            string Serialazed = JsonConvert.SerializeObject(datas, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(path + @"\Data\jsonData.json"))
            {
                sw.WriteLine(Serialazed);
            }

            #endregion 
        }

        #region Directory/File Task Method
        static async Task<string> AsyncProgramReturn(string url)
        {
            HttpClient httpClient = new HttpClient();
            string data = await httpClient.GetStringAsync(url);
            return data;
        }

        #endregion

        /*#region Io bound methods
        public static void SyncProgram(List<string> urls)
        {
            HttpClient httpClient = new HttpClient();
            foreach (string item in urls)
            {
                httpClient.GetStringAsync(item).Result.ToString();
            }
        }
        public static async Task ASyncProgram(List<string> urls)
        {
            HttpClient httpClient = new HttpClient();
            List<Task<string>> tasks = new List<Task<string>>();
            foreach (string item in urls)
            {
                tasks.Add(httpClient.GetStringAsync(item));
            }
            await Task.WhenAll(tasks);
        }
        #endregion*/


    }
}
