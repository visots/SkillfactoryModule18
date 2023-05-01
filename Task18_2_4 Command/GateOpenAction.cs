namespace Task18_2_4_Command
{
    internal class GateOpenAction : IAction
    {
        private Gate _gate;

        public GateOpenAction(Gate gate)
        {
            _gate = gate;
        }

        public void Run()
        {
            _gate.Open();
        }

        public void Undo()
        {
            _gate.Close();
        }
    }
}