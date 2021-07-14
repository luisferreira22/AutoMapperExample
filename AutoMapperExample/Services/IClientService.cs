using AutoMapperExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperExample.Services
{
    public interface IClientService
    {
        ClientViewModel GetClient();
    }
}
