using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask18_4_1
{
    public interface ILoaderCommand
    {
        public void Load(string uri);

        public void GetInfo();
    }
}
