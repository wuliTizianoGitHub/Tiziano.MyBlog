using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiziano.MyBlog.Authorization.Permissions;

namespace Tiziano.MyBlog.Permissions.Dto
{
    [AutoMapFrom(typeof(Permission))]
    public class GetAllMenuPermissionOutput:EntityDto
    {
        public string DisplayNmae { get; set; }

        public long ParentPermissionId { get; set; }

        public  PermissionType PermissionType { get; set; }

        public List<GetAllMenuPermissionOutput> ChildPermission { get; set; }
    }
}
