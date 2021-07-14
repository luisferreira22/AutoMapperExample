using AutoMapper;
using AutoMapperExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperExample.Profiles
{
    public class ClientProfile:Profile
    {

        public ClientProfile() 
        {
            CreateMap<Client, ClientViewModel>();
                //In case the properties do not match
               //between the view and the model with ForMember, we specify
               //the matching between the properties of one and the other.
                // .ForMember(dest=> dest.FirstName, opt=>opt.MapFrom(src=> src.FirstName))

        }
    }
}
