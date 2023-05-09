using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask18_4_1
{
    internal class VideoLoader
    {
        ILoaderCommand _command;

        public void SetCommand(ILoaderCommand command)
        {
            _command = command;
        }

        public void LoadVideo(string uri)
        {
            _command.Load(uri);
        }

        public VideoInfo GetVideoInfo(string uri)
        {
            return _command.GetInfo(uri);
        }

    }
}
