using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webb.Views.Domain;

namespace Webb.Models
{
    public class ModelHelper:Profile
    {
        public ModelHelper()
        {
            CreateMap<Product, ProductModels>();
            CreateMap<UserRegistrationModel, User>();
        }
    }
}
