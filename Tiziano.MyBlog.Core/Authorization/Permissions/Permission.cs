using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiziano.MyBlog.Authorization.Permissions
{
    public class Permission:Abp.Authorization.PermissionSetting
    {
        public virtual long ParentPermissionId { get; set; } 
    }
}
