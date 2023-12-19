using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_and_deserialization
{

    [Serializable]
    [KnownType(typeof(Student))]
    [XmlInclude(typeof(Student))]
    [DataContract]
    public abstract class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Phone { get; set; }
        public Person()
            : this(string.Empty, string.Empty, 0, string.Empty)
        {

        }
        public Person(string name, string surname, int age, string phone)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Phone = phone;
        }

        
    }
}
