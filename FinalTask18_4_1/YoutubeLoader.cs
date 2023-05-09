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
    public class YoutubeLoader
    {
        private YoutubeClient _client;

        public YoutubeLoader()
        {
            _client = new YoutubeClient();
        }

        public VideoInfo GetInfo(string uri)
        {
            var video = _client.Videos.GetAsync(uri);
            return new VideoInfo()
            {
                Author = video.Result.Author.ToString(),
                Title = video.Result.Title.ToString(),
                Description = video.Result.Description.ToString()
            };

        }

        public void Download(string uri)
        {
            if (!String.IsNullOrWhiteSpace(uri))
            {

                DownloadAsync(uri).Wait();
            }
            else
                throw new Exception("Ссылка на видео не может быть пустой");
        }

        private async Task DownloadAsync(string uri)
        {
            Console.WriteLine("Loading...");

            string filePath = AppDomain.CurrentDomain.BaseDirectory;

            var progress = new Progress<double>();
            progress.ProgressChanged += (s, e) =>
            {
                string progressMsg = "Загружено: ";
                Console.WriteLine($"{progressMsg}{e:P2}");
            };

            try
            {
                var video = _client.Videos.GetAsync(uri);
                var streamManifest = await _client.Videos.Streams.GetManifestAsync(uri);
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                await _client.Videos.DownloadAsync(uri, $"{filePath}/{video.Result.Title}.{streamInfo.Container}", progress);

                Console.WriteLine("Complete!");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка!\n" + e.Message);
            }
        }
    }
}
