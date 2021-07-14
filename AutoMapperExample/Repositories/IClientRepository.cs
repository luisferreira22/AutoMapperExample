using AutoMapperExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperExample.Repositories
{
    public interface IClientRepository
    {
        Client Getclient();
    }
}
