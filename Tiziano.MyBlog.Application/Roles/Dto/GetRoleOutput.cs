using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiziano.MyBlog.Authorization.Roles;

namespace Tiziano.MyBlog.Roles.Dto
{ 
    [AutoMapFrom(typeof(Role))]
    public class GetRoleOutput: EntityDto
    {
        public string DisplayName { get; set; }
    }
}
