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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet("effect/{id}")]
        public async Task<ActionResult<Effects>> GetEffect(int id)
        {
            return await _categoryService.GetEffect(id);
        }

        [HttpGet("ailment/{id}")]
        public async Task<ActionResult<Ailments>> GetAilment(int id)
        {
            return await _categoryService.GetAilment(id);
        }

        [HttpGet("flavor/{id}")]
        public async Task<ActionResult<Flavors>> GetFlavor(int id)
        {
            return await _categoryService.GetFlavor(id);
        }


        [HttpPost("create-effect")]
        public async Task<ActionResult<Effects>> PostEffect([FromBody] Effects effect)
        {
            try
            {
                var newEffect = await _categoryService.CreateEffect(effect);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create-ailment")]
        public async Task<ActionResult<Ailments>> PostAilment([FromBody] Ailments ailment)
        {
            try
            {
                var newAilment = await _categoryService.CreateAilment(ailment);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create-flavor")]
        public async Task<ActionResult<Flavors>> PostFlavor([FromBody] Flavors flavor)
        {
            try
            {
                var newFlavor = await _categoryService.CreateFlavor(flavor);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
