using AutoMapperExample.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperExample.Controllers
{
    public class ClientController : Controller
    {

        private readonly IClientService _service;

        public ClientController(IClientService service) 
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var client = _service.GetClient();
            return View(client);
        }
    }
}
