using System.Diagnostics;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace FinalTask18_4_1
{
    internal class Program
    {
        static string title = "";
        static string outputFilePath = "C:\\Users\\visot\\source\\repos\\SkillFactory\\SkillfactoryModule18\\FinalTask18_4_1\\bin\\Debug\\net6.0\\";
        private static YoutubeClient _client;
        static string link = "https://www.youtube.com/watch?v=smaG-Bsf2p4";

        static void Main(string[] args)
        {

            _client = new YoutubeClient();
            DownloadAsync(link);

            Task task = new Task(() => DownloadAsync(link));
            task.Wait();
        }


        public static async void DownloadAsync(string uri)
        {
            //try
            //{
            Console.WriteLine("Download video");

            var progress = new Progress<double>();
            progress.ProgressChanged += (s, e) =>
            {
                    string progressMsg = "Загружено: ";
                    Console.WriteLine($"{progressMsg}{e:P2}");
                    //Console.SetCursorPosition(0, Console.CursorTop-1);
                    //Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
            };

            var video = _client.Videos.GetAsync(uri);
            var streamManifest = await _client.Videos.Streams.GetManifestAsync(uri);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            await _client.Videos.DownloadAsync(uri, $"{outputFilePath}/{video.Result.Title}.{streamInfo.Container}", progress);
            Console.WriteLine("Video downloaded");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}