using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using prEntidades;
using prDTO; 

namespace ProductsWebAPI.Utility
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {           
            CreateMap<ProductAddUpdDTO, Product>().ReverseMap ()
               .ForMember(x => x.IMAGE , options => options.Ignore());

            CreateMap<ProductDTO, Product>().ReverseMap(); 
                    
          


        }
    }
}
