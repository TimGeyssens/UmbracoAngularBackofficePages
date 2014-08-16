using System.Runtime.Serialization;

namespace UmbracoAngularBackofficePages
{
    [DataContract(Name = "person")]
    public class Person
    {
        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;

        }

        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}