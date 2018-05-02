using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDALEF;
using TestEntities;
namespace TestBll
{
    public class Bll
    {
        Dal d = new Dal();

        public List<PersonView> GetPersons()
        {
            PersonView p = new PersonView();
            List<PersonView> pers = new List<PersonView>();
            List<Person> personlist = d.GetPersons();
            foreach (Person per in personlist)
            {
                p = new PersonView { ID = per.PersonID, Name = per.Name };
                pers.Add(p);
            }
            return pers;
        }
    }
}
