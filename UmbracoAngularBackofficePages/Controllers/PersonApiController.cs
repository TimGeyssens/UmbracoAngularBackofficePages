using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Persistence;
using Umbraco.Web.Editors;
using Umbraco.Web.Mvc;

namespace UmbracoAngularBackofficePages.Controllers
{
    [PluginController("Example")]
    public class PersonApiController : UmbracoAuthorizedJsonController
    {
        public IEnumerable<Person> GetAll()
        {
         
            var query = new Sql().Select("*").From("people");
            return DatabaseContext.Database.Fetch<Person>(query);
        }

        public Person GetById(int id)
        {
           
            var query = new Sql().Select("*").From("people").Where<Person>(x => x.Id == id);
            return DatabaseContext.Database.Fetch<Person>(query).FirstOrDefault();
            
        }

        public Person PostSave(Person person)
        {
            if (person.Id > 0)
                DatabaseContext.Database.Update(person);
            else
                DatabaseContext.Database.Save(person);

            return person;
        }

        public int DeleteById(int id)
        {
            return DatabaseContext.Database.Delete<Person>(id);     
        }

    }
}
