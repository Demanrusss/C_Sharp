using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializeArray
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [OptionalField]
        public string address;
        public bool DeserializedVersion = false;

        // Constructor
        public Person()
        {
            Name = "Name";
            Surname = "Surname";
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        // Serialization managing
        [OnSerializing]
        internal void OnSerializingMethod(StreamingContext context)
        {
            //
        }

        [OnSerialized]
        internal void OnSerializedMethod(StreamingContext context)
        {
            //
        }

        [OnDeserializing]
        internal void OnDeserializingMethod(StreamingContext context)
        {
            //
        }

        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            DeserializedVersion = true;
        }
    }
}
