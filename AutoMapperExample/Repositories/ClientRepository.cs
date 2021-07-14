using AutoMapperExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperExample.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Client Getclient()
        {
            return new Client
            {
                Id = 1,
                FirstName = " Lando",
                LastName = "Norris",
                Email = "LandoNorris@McLaren.com",
                Phone = "123456",
                Address = new Address
                {
                    Street = "San Remo",
                    Number = 123,
                    City="Monaco"
                }
            };
        }
    }
}
