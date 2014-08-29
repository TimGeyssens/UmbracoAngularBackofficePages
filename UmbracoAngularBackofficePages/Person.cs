using System.Runtime.Serialization;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace UmbracoAngularBackofficePages
{
    [TableName("People")]
    [DataContract(Name = "person")]
    public class Person
    {
        public Person(){}   
        
        [PrimaryKeyColumn(AutoIncrement = true)]
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "pictureId")]
        public int PictureId { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}