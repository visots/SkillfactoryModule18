namespace Task18_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiclePlant vehiclePlant = new VehiclePlant();
            
            Conveyor conveyor = new ScooterConveyor();
            vehiclePlant.Construct(conveyor);
            conveyor.Product.Show();

            conveyor = new CarConveyor();
            vehiclePlant.Construct(conveyor); 
            conveyor.Product.Show();

            conveyor = new MotoConveyor();
            vehiclePlant.Construct(conveyor);
            conveyor.Product.Show();
        }
    }
}