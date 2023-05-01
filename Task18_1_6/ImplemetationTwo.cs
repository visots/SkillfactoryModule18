namespace Task18_1_6
{
    internal class ImplementationTwo : BaseClass
    {
        public ImplementationTwo(int id) : base(id)
        {
        }

        public override BaseClass Clone()
        {
            return new ImplementationOne(Id);
        }
    }
}