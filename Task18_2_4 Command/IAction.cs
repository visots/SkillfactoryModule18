using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18_2_4_Command
{
    internal interface IAction
    {
        void Run();

        void Undo();
    }
}
