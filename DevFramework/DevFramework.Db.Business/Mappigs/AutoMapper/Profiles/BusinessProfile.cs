using AutoMapper;
using DevFramework.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.Business.Mappigs.AutoMapper.Profiles
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile() : base()
        {
            CreateMap<Product, Product>();
        }
    }
}
