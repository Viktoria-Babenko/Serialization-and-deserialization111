using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_and_deserialization
{
    [Serializable]
    [DataContract]
    public class Student : Person
    {
        [DataMember]
        public double Average { get; set; }
        [DataMember]
        public int Number_Of_Group { get; set; }
        public Student() : this(string.Empty, string.Empty, 0, string.Empty, 0, 0)
        {

        }
        public Student(string name, string surname, int age, string phone, double average, int number_of_group)
            : base(name, surname, age, phone)
        {
            Average = average;
            Number_Of_Group = number_of_group;
        }
    }
}
