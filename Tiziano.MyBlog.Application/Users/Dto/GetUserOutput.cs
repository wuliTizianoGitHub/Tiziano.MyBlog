using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiziano.MyBlog.Users.Dto
{
    [AutoMapFrom(typeof(User))]
    public class GetUserOutput: EntityDto<long>
    {
        [Required]
        [StringLength(User.MaxSurnameLength)]
        public string Surname { get; set; }

        public string ProfilePhoto { get; set; }
    }
}
