using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Tiziano.MyBlog.MultiTenancy;

namespace Tiziano.MyBlog.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}