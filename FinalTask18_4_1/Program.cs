using System.Diagnostics;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace FinalTask18_4_1
{
    internal class Program
    {
        //static string link = "https://www.youtube.com/watch?v=smaG-Bsf2p4";

        static void Main(string[] args)
        {
            Console.WriteLine("Введите ссылку на видео:");
            
            string link = Console.ReadLine();

            VideoLoader videoLoader = new VideoLoader();
            YoutubeLoader youtubeLoader = new YoutubeLoader();

            videoLoader.SetCommand(new VideoLoaderAction(youtubeLoader));

            var info = videoLoader.GetVideoInfo(link);

            Console.WriteLine($"Title: {info.Title} \nAuthor: {info.Author}\nDescription: {info.Description}\n");

            videoLoader.LoadVideo(link);
        }
    }
}