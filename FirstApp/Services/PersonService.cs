using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace FirstApp.Services
{
    public class PersonService : IPeopleService
    {
        private readonly FirstAppContext _context;
        public PersonService(FirstAppContext con)
        {
            _context = con;
        }

        public async Task<bool> Create(Person p)
        {
            definePersonId(ref p);

            _context.Person.Add(p);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PersonExists(p.getPersonId()))
                {
                    return true;
                }
                else
                {
                    throw;
                }
            }

            return false;
        }

        private void definePersonId(ref Person person)
        {
            //assign an ID for the instance
            //normal you give a unique value like GUID type but in this case we will leave an random int

            person.setPersonId(new Random().Next(100000));
        }

        public async Task<bool> Delete(int id)
        {
            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return false;
            }

            _context.Person.Remove(person);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<ActionResult<IEnumerable<Person>>> GetAllPersons()
        {
            return await _context.Person.ToListAsync();
        }

        public async Task<Person> GetPerson(int id)
        {
            var person = await _context.Person.FindAsync(id);

            return person;
        }

        public async Task<bool> Update(int id, Person p)
        {

            _context.Entry(p).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
            return true;
        }


        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.getPersonId() == id);
        }
    }
}
