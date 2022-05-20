
namespace Listing_8_3
{
    internal class Person
    {
        private string name;
        private string surname;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public Person (string firstName, string lastName)
        {
            Name = firstName;
            Surname = lastName;
        }
    }
}
