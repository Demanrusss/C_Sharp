using System;
using System.Collections;
using PersonClass;

namespace ArrayListProject
{
    internal class SortTest : IComparer
    {
        int IComparer.Compare(Object person1, Object person2)
        {
            string personName1 = ((Person)person1).ToString();
            string personName2 = ((Person)person2).ToString();

            return personName2.CompareTo(personName1);
        }
    }
}
