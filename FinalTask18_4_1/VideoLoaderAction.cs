using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask18_4_1
{
    internal class VideoLoaderAction : ILoaderCommand
    {

        private VideoLoader _videoLoader;

        VideoLoaderAction(VideoLoader videoLoader)
        {
            _videoLoader = videoLoader;
        }

        public void Load(string uri)
        {
            _videoLoader.Download(uri);
        }

        public void GetInfo()
        {
           _videoLoader.GetInfo();
        }
    }
}
