using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateProject
{
    // Also we can use: public class TemplateTest<T> where T : XXXXX
    // XXXXX: Class, struct, new(), Name_of_Class, Name_of_Interface
    // Example:
    // public class TemplateTest<T> where T : Person


    // Here is universal one
    public class TemplateTest<T>
    {
        T[] array = new T[10];
        int index = 0;

        public bool Add(T value)
        {
            if (index >= 10)
                return false;

            array[index++] = value;
            return true;
        }

        public T Get(int index)
        {
            if (index < this.index && index >= 0)
                return array[index];
            else
                return default(T);
        }

        public int Count()
        {
            return index;
        }
    }
}
