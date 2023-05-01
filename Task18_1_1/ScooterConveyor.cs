using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18_1_1
{
    class ScooterConveyor : Conveyor
    {

        public ScooterConveyor() 
        {
            _product = new Product("Cкутер");
        }

        public override void BuildDoors()
        {
            _product["doors"] = "0";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "25 л.с.";
        }

        public override void BuildFrame()
        {
            _product["frame"] = "Рама скутера";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "2";
        }
    }
}
