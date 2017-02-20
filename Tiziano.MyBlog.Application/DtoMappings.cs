using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiziano.MyBlog.Users;
using Tiziano.MyBlog.Users.Dto;

namespace Tiziano.MyBlog
{
    internal static class DtoMappings
    {
        public static void Map(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<User, GetUserOutput>().ForMember(g => g.Id, opts => opts.MapFrom(d => d.Id));
        }
    }
}
