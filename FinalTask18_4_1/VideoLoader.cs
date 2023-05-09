using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace FinalTask18_4_1
{
    internal class VideoLoader
    {
        private YoutubeClient _client;
        
        public VideoLoader() 
        {
            _client = new YoutubeClient();
        }

        public void GetInfo()
        {

        }

        public void Download(string uri)
        {
            if (!String.IsNullOrWhiteSpace(uri))
            {
                Console.WriteLine("Loading...");
                Task task = new Task(() => DownloadAsync(uri));
                task.Wait();
                Console.WriteLine("Complete!");
            }
            else
                throw new Exception("Ссылка на видео не может быть пустой");

        }

        private async void DownloadAsync(string uri)
        {
            try
            {
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
            await _client.Videos.DownloadAsync(uri, $"{Assembly.GetExecutingAssembly().Location}/{video.Result.Title}.{streamInfo.Container}", progress);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
