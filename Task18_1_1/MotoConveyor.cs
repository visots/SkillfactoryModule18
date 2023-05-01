using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18_1_1
{
    internal class MotoConveyor : Conveyor
    {
        public MotoConveyor()
        {
            _product = new Product("Мотоцикл");
        }
        public override void BuildDoors()
        {
            _product["doors"] = "0";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "50 л.с.";
        }

        public override void BuildFrame()
        {
            _product["frame"] = "Рама мотоцикла";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "2";
        }
    }
}
