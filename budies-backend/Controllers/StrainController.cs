using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using budies_backend.Models;
using budies_backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace budies_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StrainController : ControllerBase
    {
        private readonly IStrainService _strainService;
        public StrainController(IStrainService strainService)
        {
            _strainService = strainService;
        }

        [HttpGet]
        public async Task<string> GetStrains()
        {
            return "hui";
            //return await _strainService.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Strains>> GetStrains(int id)
        {
            return await _strainService.Get(id);
        }

        [HttpPost("create-strain")]
        public async Task<ActionResult<Strains>> PostStrain([FromBody] Strains strain)
        {
            try
            {
                var newStrain = await _strainService.Create(strain);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
