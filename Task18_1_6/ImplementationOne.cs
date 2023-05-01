namespace Task18_1_6
{
    internal class ImplementationOne : BaseClass
    {
        public ImplementationOne(int id) :base (id)
        {
        }

        public override BaseClass Clone()
        {
            return new ImplementationOne(Id);
        }
    }
}