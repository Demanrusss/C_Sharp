using System.Collections;

namespace ArrayListProject
{
    internal class PersonEnumerator : IEnumerator
    {
        int currIndex = -1;
        PersonClass.Person person;

        public PersonEnumerator(PersonClass.Person person)
        {
            this.person = person;
        }

        #region IEnumerator Members

        public object Current
        {
            get { return person[currIndex]; }
        }

        public bool MoveNext()
        {
            currIndex++;
            if (currIndex >= person.GetChildrenNumber())
                return false;
            else
                return true;
        }

        public void Reset()
        {
            currIndex = -1;
        }

        #endregion
    }
}
