using Management2.Models;
using Management2.Processor;
using Management2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Management2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ManagmentController : ControllerBase
    {
        private readonly Iprocessor _data;
        private readonly ILogger<ManagmentController> _logger;
        public ManagmentController(Iprocessor data, ILogger<ManagmentController> logger)
        {
            _data = data;
            _logger = logger;
        }
        [HttpPost]
        public IActionResult AddDcotor(Doctor req)
        {
            bool response = false;
            try
            {
                response = _data.AddDoctor(req);
            }catch(Exception ex)
            {
                _logger.LogError("Exception occured at:", ex);
            }
            return Ok(response);
        }
        [HttpGet]
        public IActionResult GetListDoctor()
        {
            try
            {
                List<Doctor> lstDoc = _data.GetDoctorList();
                return Ok(lstDoc);
            }catch(Exception ex)
            {
                _logger.LogError("Exception occured at:", ex);
                return BadRequest();
            }
           
        }
    }
}
