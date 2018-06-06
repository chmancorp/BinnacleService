using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BinnacleService.Data.DTOBinnacle;
using BinnacleService.Data.Models;
using BinnacleService.Data.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BinnacleService.Controllers
{
    [Produces("application/json")]
    [Route("api/Binnacle")]
    public class BinnacleController : Controller
    {
        private readonly IUnitBinnacle _binnacleunit;

        [HttpPost]
        public async Task<IActionResult> PostBinnacle(DTOBinnacle binnacleData)
        {
            Binnacle binnacleSave = new Binnacle();
            binnacleSave = AutoMapper.Mapper.Map<Binnacle>(binnacleData);

            _binnacleunit.Repository.SaveBinnacle(binnacleSave);
            _binnacleunit.Complete();

            return Ok();
        }
    }
}