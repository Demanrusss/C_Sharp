
namespace InterfaceProject
{
    internal class Person: IPurse
    {
        // Methods of class Person
        public string name;
        public string surname;

        public string FirstName
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return surname; }
            set { surname = value; }
        }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        // Realization of interface
        int sum = 0;
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public void AddMoney(int sum)
        {
            Sum += sum;
        }
        public int DecMoney(int sum)
        {
            Sum -= sum;
            return sum;
        }
    }
}
