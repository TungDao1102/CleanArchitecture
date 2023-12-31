﻿using CleanArchitecture.ApplicationCore.Commons;
using CleanArchitecture.ApplicationCore.Entities;
using CleanArchitecture.ApplicationCore.Interfaces.Repositories;
using CleanArchitecture.ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class VillaAPIController : ControllerBase
    {
        private readonly IVillaService _villaService;
        public VillaAPIController(IVillaService villaService)
        {
            _villaService = villaService;
        }
        [HttpPost("CreateVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize]
        public async Task<ActionResult<ResponseDTO>> CreateVilla([FromForm] Villa villa)
        {
            return Ok(await _villaService.CreateVilla(villa));
        }

        [HttpGet("GetAllVilla")]
        
        public async Task<ActionResult<ResponseDTO>> GetAllVilla()
        {
            return Ok(await _villaService.GetAllVilla());
        }

        [HttpGet("GetVilla/{villaId:int}")]
        public async Task<ActionResult<ResponseDTO>> GetVilla([FromRoute] int villaId)
        {
            return Ok(await _villaService.GetVilla(villaId));
        }

        [HttpPut("UpdateVilla")]
        [Authorize]
        public async Task<ActionResult<ResponseDTO>> UpdateVilla([FromForm] Villa villa)
        {
            return Ok(await _villaService.UpdateVilla(villa));
        }

        [HttpDelete("DeleteVilla/{villaId:int}")]
        [Authorize]
        public async Task<ActionResult<ResponseDTO>> DeleteVilla([FromRoute] int villaId)
        {
            return Ok(await _villaService.DeleteVilla(villaId));
        }

        [HttpGet("GetAllDetailVilla")]
        public async Task<ActionResult<ResponseDTO>> GetAllDetailVilla(int nights, DateOnly checkInDate)
        {
            return Ok(await _villaService.GetAllDetailVilla(nights, checkInDate));
        }

        [HttpGet("IsVillaAvailableByDate")]
        public async Task<ActionResult<ResponseDTO>> IsVillaAvailableByDate(int villaId, int nights, DateOnly checkInDate)
        {
            return Ok(await _villaService.IsVillaAvailableByDate(villaId, nights, checkInDate));
        }
    }
}
