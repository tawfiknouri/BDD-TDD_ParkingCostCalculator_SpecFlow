using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkCostCalc.Core.Interfaces;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Services;

namespace ParkCostCalc.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
       

        public ContactController(IContactService contactService, IEmailSender emailSender)
        {
            _contactService = contactService;
            
        }

        [HttpPost]
        public IActionResult ContactUs([FromBody] Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var dbContact = _contactService.ContactUs(contact);
            if (dbContact == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error during adding contact!");
            }

            return Ok(dbContact);
        }

    }
}
