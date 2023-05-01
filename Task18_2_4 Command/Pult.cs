namespace Task18_2_4_Command
{
    internal class Pult
    {
        IAction _action;

        internal void CloseButton()
        {
            _action.Undo();
        }

        internal void OpenButton()
        {
            _action.Run();
        }

        internal void SetAction(IAction action)
        {
            _action = action;
        }
    }
}