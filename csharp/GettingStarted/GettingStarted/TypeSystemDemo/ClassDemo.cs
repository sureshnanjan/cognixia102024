namespace TypeSystemDemo
{
    public class ClassDemo : IComparable<ClassDemo>, IInterfaceDemo
    {
        public int id;
        public string name;
        public static int instancenumber = 0;
        public ClassDemo(int id, string name)
        {
            this.id = id;
            this.name = name;
            instancenumber++;
            //Array.BinarySearch
        }

        public int CompareTo(ClassDemo? other)
        {
            return this.name.CompareTo(other.name);
        }

        public void MyVoidMethod()
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return $"{this.id}-{this.name}";
        }
    }
}
