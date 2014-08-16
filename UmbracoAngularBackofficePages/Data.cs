using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoAngularBackofficePages
{
    public class Data
    {
        public static IEnumerable<Person> GetAll()
        {
            var data = new List<Person>();
            data.Add(new Person(1, "Jeff", "Trent"));
            data.Add(new Person(2, "Paula", "Trent"));
            data.Add(new Person(3, "Lieutenant", "Harper"));
            data.Add(new Person(4, "Colonel", "Edwards"));
            data.Add(new Person(5, "Patrolman", "Larry"));
            return data;
        }

        public static Person GetById(int id)
        {

            return GetAll().Where(p => p.Id == id).FirstOrDefault();
        }
    }
}