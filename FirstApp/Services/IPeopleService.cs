using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace FirstApp.Services
{
    public interface IPeopleService
    {

        Task<ActionResult<IEnumerable<Person>>> GetAllPersons();
        Task<Person> GetPerson(int id);
        Task<bool> Create(Person p);
        Task<bool> Update(int id, Person p);
        Task<bool> Delete(int id);
    }
}
