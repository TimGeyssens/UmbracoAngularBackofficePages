using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Editors;
using Umbraco.Web.Mvc;

namespace UmbracoAngularBackofficePages.Controllers
{
    [PluginController("Example")]
    public class PersonApiController : UmbracoAuthorizedJsonController
    {
        public Person GetById(int id)
        {
            return Data.GetById(id);
            
        }

        public Person PostSave(Person person)
        {
            //if (person.Id > 0)
                // Update;
            //else
                // Insert;

            return person;
        }

    }
}
