using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Services;

namespace ParkCostCalc.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IEmailService _emailService;

        public ContactController(IContactService contactService, IEmailService emailService)
        {
            _contactService = contactService;
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult ContactUs([FromBody] Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var dbContact = _contactService.CreateContact(contact);
            if (dbContact == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error during adding contact!");
            }

            var emailSatus = _emailService.SendEmailToSupport(dbContact);

            return Ok(emailSatus);
        }

    }
}
