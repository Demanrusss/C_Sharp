using System.Collections;

namespace Listing_8_3
{
    internal class Children
    {
        ArrayList children = new ArrayList();

        public void AddChild(string firstName, string lastName)
        {
            children.Add(new Person(firstName, lastName));
        }

        public void DeleteChild(int index)
        {
            children.RemoveAt(index);
        }

        public Person GetChild(int index)
        {
            return (Person)children[index];
        }

        public int GetChildrenNumber()
        {
            return children.Count;
        }

        public Person this[int index]
        {
            get { return (Person)children[index]; }
        }
    }
}
