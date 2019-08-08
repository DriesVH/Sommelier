using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sommelier.Models;
using Sommelier.Services.Consultants;

namespace Sommelier.WebApp.Controllers
{
    public class ConsultantsController : Controller
    {
        private readonly IConsultantsService ConsultantsService;

        public ConsultantsController(IConsultantsService ConsultantsService)
        {
            this.ConsultantsService = ConsultantsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Consultants = this.ConsultantsService.GetAllConsultants();
            return Ok(Consultants);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var Consultant = this.ConsultantsService.GetConsultantById(id);
            if (Consultant == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Consultant);
            }
        }

        [HttpPost]
        public IActionResult Post(Consultant Consultant)
        {
            var newConsultant = this.ConsultantsService.CreateConsultant(Consultant);
            return CreatedAtAction("get", newConsultant);
        }

        [HttpDelete]
        public IActionResult Delete(Consultant Consultant)
        {
            this.ConsultantsService.DeleteConsultant(Consultant);
            return NoContent();
        }
    }
}