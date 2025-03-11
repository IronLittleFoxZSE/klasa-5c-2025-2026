using Microsoft.EntityFrameworkCore;
using PeopleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleDatabaseClassLibrary
{
    public class PeopleRepository
    {
        private PeopleDBContext dbContext;

        public PeopleRepository()
        {
            dbContext = new PeopleDBContext(); ;
        }

        public void AddNewPerson(string name, string surname, int age)
        {
            Person person = new()
            {
                Name = name,
                Surname = surname,
                Age = age
            };
            dbContext.People.Add(person);
            dbContext.SaveChanges();
        }

        public List<Person> GetPeople()
        {
            /*
                select *
                from People4C.People p
           left join Addresses a on a.Id = p.AddressId
               where p.Age >= 18
               order by p.Surname asc, p.Name desc
            */

            return dbContext
                .People
                .Include(p => p.Address) //left join Addresses a on a.Id = p.AddressId
                .AsNoTracking()
                .Where(p => p.Age >= 18)
                .OrderBy(p => p.Surname)
                .ThenByDescending(p => p.Name)
                //.Select(p => p)
                .ToList();

        }

        public void UpdatePerson(int id, string name, string surname, int age)
        {
            /*
             update people
                set name = nameNET,
                    surname = surnameNET
                    age = ageNET
              where id = idNET
             */


            /*
                select *
                  from people
                 where id = idNET
             */ 
            //Person personToUpdate = dbContext.People.Where(p=> p.Id == id).FirstOrDefault();
            Person? personToUpdate = dbContext.People.FirstOrDefault(p => p.Id == id);
            if (personToUpdate != null)
            {
                personToUpdate.Name = name;
                personToUpdate.Surname = surname;
                personToUpdate.Age = age;
                dbContext.SaveChanges();
            }
        }

        public void DeletePerson(int id)
        {
            /*
             delete from People p
                   where p.id = idNET
             */
            Person? personToDelete = dbContext.People.FirstOrDefault(p => p.Id == id);
            if (personToDelete != null)
            {
                dbContext.People.Remove(personToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
