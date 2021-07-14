using AutoMapper;
using AutoMapperExample.Models;
using AutoMapperExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperExample.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repository;
        private readonly IMapper _mapper;
        public ClientService(IClientRepository repository,IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ClientViewModel GetClient()
        {
            var client = _repository.Getclient();
            return _mapper.Map <ClientViewModel>(client) ;
            //The mapping of a class with a view allows us to save having to load property by property of each object.
            //By using Automapper we save writing the code below which is commented.
            //return new ClientViewModel()
            //{
            //    Id = client.Id,
            //    FirstName = client.FirstName,
            //    LastName = client.LastName,
            //    Email = client.Email,
            //    Phone = client.Phone
            //};

}
    }
}
