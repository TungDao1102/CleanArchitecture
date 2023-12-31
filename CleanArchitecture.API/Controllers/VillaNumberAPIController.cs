﻿using CleanArchitecture.ApplicationCore.Commons;
using CleanArchitecture.ApplicationCore.Entities;
using CleanArchitecture.ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaNumberAPIController : ControllerBase
    {
        private readonly IVillaNumberService _service;
        public VillaNumberAPIController(IVillaNumberService service)
        {
            _service = service;
        }

        [HttpGet("GetAllVillaNumber")]
        public async Task<ActionResult<ResponseDTO>> GetAllVillaNumber([FromQuery] QueryParameter queryParameter)
        {
            return Ok(await _service.GetAllVillaNumber(queryParameter));
        }

        [HttpGet("GetVillaNumber/{villaNumberId:int}")]
         public async Task<ActionResult<ResponseDTO>> GetVillaNumber([FromRoute] int villaNumberId)
        {
            return Ok(await _service.GetVillaNumber(villaNumberId));
        }

        [HttpPost("CreateVillaNumber")]
        [Authorize]
        public async Task<ActionResult<ResponseDTO>> CreateVillaNumber([FromBody] VillaNumber villaNumber)
        {
            return Ok(await _service.CreateVillaNumber(villaNumber));
        }

        [HttpPut("UpdateVillaNumber")]
        [Authorize]
        public async Task<ActionResult<ResponseDTO>> UpdateVillaNumber(VillaNumber villaNumber)
        {
            return Ok(await _service.UpdateVillaNumber(villaNumber));
        }

        [HttpDelete("DeleteVillaNumber/{villaNumberId:int}")]
        [Authorize]
        public async Task<ActionResult<ResponseDTO>> DeleteVillaNumber([FromRoute] int villaNumberId)
        {
            return Ok(await _service.DeleteVillaNumber(villaNumberId));
        }
    }
}
