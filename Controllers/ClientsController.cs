using Microsoft.AspNetCore.Mvc;
using Services.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Controllers
{
    public class ClientsController:Controller
    {
        private readonly IClientService clientService;

        public ClientsController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        

        [HttpGet]
        public async Task<IActionResult> Index() 
        {
            var clients = clientService.GetClients();
            return Ok(clients);
        }

            
    }
}
