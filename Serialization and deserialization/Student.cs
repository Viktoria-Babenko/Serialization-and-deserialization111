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
        public void Print()
        {
            base.Print();
            Console.Write($"\t\t{Average}\t\t{Number_Of_Group}\n");
        }
        public void Add()
        {
            base.Add();
            Console.WriteLine("Введите средний балл студента:");
            Average = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер группы студента:");
            Number_Of_Group = int.Parse(Console.ReadLine());
        }
        public class SortByAge : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    return (obj1 as Student).Age.CompareTo((obj2 as Student).Age);

                throw new NotImplementedException();
            }
        }
    }
}
