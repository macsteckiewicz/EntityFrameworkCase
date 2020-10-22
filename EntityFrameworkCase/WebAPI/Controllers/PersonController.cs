using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EntityFrameworkCase.Domain.DataTransferObjects;
using EntityFrameworkCase.Domain.Interfaces.RepositoryInterfaces;
using EntityFrameworkCase.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IWrapperRepository _wrapperRepository;
        private readonly IMapper _mapper;

        public PersonController(IWrapperRepository wrapperRepository, IMapper mapper)
        {
            _wrapperRepository = wrapperRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllPeople()
        {
            throw new NotImplementedException();

            var people = _wrapperRepository.Person.FindAll();

            if (people == null)
            {
                return NotFound();
            }

            var peopleResult = _mapper.Map<IEnumerable<PersonDto>>(people);

            return Ok(peopleResult);
        }

        [HttpGet("{id}", Name = "PersonById")]
        public IActionResult GetPersonById(int id)
        {
            var person = _wrapperRepository.Person.FindByCondition(s => s.Id.Equals(id)).SingleOrDefault();

            if (person == null)
            {
                return NotFound();
            }

            var personResult = _mapper.Map<PersonDto>(person);

            return Ok(personResult);
        }

        // Test data:

        //{
	       // "FirstName" : {
		      //  "Id" : 1,
		      //  "Name" : "Jan"
	       // },	
	       // "SecondName" : {
		      //  "Id": 2,
		      //  "Name": "Jakub"
	       // },
	       // "Surname" : {
		      //  "Id": 1,
		      //  "Name": "Kowalski"
	       // },	
	       // "MotherSurname" : {
		      //  "Id": 2,
		      //  "Name": "Nowak"
	       // },	
	       // "BirthCity" : {
		      //  "Id": 1,
		      //  "Name": "Warszawa"
	       // },	
	       // "Workplace" : {
		      //  "Id": 1,
		      //  "City" : {
			     //   "Id" : 1,
			     //   "Name" : "Warszawa"
		      //  }, 
		      //  "Street" : {
			     //   "Id" : 1,
			     //   "Name" : "Wiejska"
		      //  }
	       // }
        //}

    [HttpPost]
        public IActionResult CreatePerson(PersonDto personDto)
        {
            if (personDto == null)
            {
                return BadRequest("Object is null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            var person = _mapper.Map<Person>(personDto);

            _wrapperRepository.Person.Create(person);

            _wrapperRepository.Save();

            var createdPerson = _mapper.Map<PersonDto>(person);

            return CreatedAtAction("PersonById", new { id = createdPerson.Id }, createdPerson);
        }
    }
}
