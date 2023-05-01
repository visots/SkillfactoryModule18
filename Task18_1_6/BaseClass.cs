namespace Task18_1_6
{
    internal abstract class BaseClass
    {
        public int Id;

        public BaseClass(int id) 
        {
            Id = id;
        }

        public void GetId()
        {
            Console.WriteLine($"Создан объект с Id {Id}");
        }

        public abstract BaseClass Clone();
    }
}