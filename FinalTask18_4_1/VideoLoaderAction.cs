using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask18_4_1
{
    public class VideoLoaderAction : ILoaderCommand
    {

        private YoutubeLoader _videoLoader;

        public VideoLoaderAction(YoutubeLoader videoLoader)
        {
            _videoLoader = videoLoader;
        }

        public void Load(string uri)
        {
            _videoLoader.Download(uri);
        }

        public VideoInfo GetInfo(string uri)
        {
           return _videoLoader.GetInfo(uri);
        }
    }
}
