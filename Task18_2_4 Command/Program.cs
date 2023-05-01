namespace Task18_2_4_Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            Gate gate = new Gate();

            pult.SetAction(new GateOpenAction(gate));
            pult.OpenButton();
            pult.CloseButton();
        }
    }
}